using Mint.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Topas4Lib;

namespace Topas4LibExample{
    class Topas4SDKExample {

        private TopasDevice Topas { get; }
        public string SerialNumber { get; }



        public Topas4SDKExample (string serialNumber) {
            if (string.IsNullOrEmpty (serialNumber)) throw new ArgumentException ($"{nameof (serialNumber)} is null or empty.", nameof (serialNumber));
            SerialNumber = serialNumber;

            //location of all available devices, just for demonstration
            var devices = Mint.Services.MintServicesClientHelpers.LocateDevices ();
            foreach (var item in devices) {
                Console.WriteLine ("SN: " + item.SerialNumber + ", address: " + item.PublicApiRestUrl_Version0 + ", has access right? " + item.CallerHasAccessRights);
            }

            Topas = TopasDevice.FindTopasDevice (serialNumber);
            if (Topas == null) {
                Console.WriteLine ("Device with serial number " + SerialNumber + " not found.");
            }
        }


        public void Run () {

            if (Topas == null) {
                Console.WriteLine ("Press any key to exit");
                Console.ReadKey ();
                return;
            }


            GetCalibrationInfoAndSetWavelength ();

            Thread.Sleep (200);
            ChangeShutter ();

            var availableMotors = Topas.MotorsService.GetAllProperties ().Motors;
            if (availableMotors.Count > 0) {
                TweakMotorPosition (availableMotors.First ());

            }


            Console.WriteLine ("Press any key to exit");
            Console.ReadKey ();
        }



        public void ChangeShutter () {
            var isShutterOpen = Topas.ShutterService.GetIsShutterOpen ();
            Console.WriteLine (@"Do you want to " + (isShutterOpen ? "close" : "open") + @" shutter? (Y\N)");
            var answer = Console.ReadLine ();
            if (answer.ToUpperInvariant () == "Y" || answer.ToUpperInvariant () == "YES") {
                Topas.ShutterService.SetOpenCloseShutter (!isShutterOpen);//invert previous state
            }
        }


        /// <summary>
        /// Get basic calibration info and set random wavelength using random interaction
        /// </summary>
        public void GetCalibrationInfoAndSetWavelength () {
            var interactions = Topas.WavelengthService.GetExpandedInteractions ();
            Console.WriteLine ("Available interactions:");
            foreach (var item in interactions) {
                Console.WriteLine (item.Type + " " + item.OutputRange.From + " - " + item.OutputRange.To + " nm");
            }

            if (interactions.Count > 0) {
                var random = new Random ();
                Console.WriteLine ("");
                var interaction = interactions[random.Next (0, interactions.Count)]; //set wavelength using random interaction
                //wavelength is selected randomly too, to be in valid range for that interaction
                var wavelengthToSet = interaction.OutputRange.From + random.NextDouble () * interaction.OutputRange.Diff;
                Console.WriteLine ("setting wavelength " + wavelengthToSet + " using interaction " + interaction.Type);
                Topas.SetWavelength (wavelengthToSet, interaction.Type);

                //if I don't care about interaction used:
                //Topas.WavelengthService.SetOutputAnyInteraction (wavelengthToSet);
                WaitTillWavelengthIsSet ();

            } else {
                Console.WriteLine ("There are no calibrated interactions.");
            }
        }


        /// <summary>
        /// Waits till wavelength setting is finished. If user needs to do any manual operations (e.g. chnge wavelength separator), inform him/her and wait for confirmation.
        /// </summary>
        /// <param name="topas"></param>
        public void WaitTillWavelengthIsSet () {
            do {
                var s = Topas.WavelengthService.GetOutput ();
                //wait till wavelength setting is done (i.e. motors are in place) or failed
                Console.Write ("\r" + (s.WavelengthSettingCompletionPart * 100d).ToString ("N2") + " % done     ");
                if (s.IsWavelengthSettingInProgress == false || s.IsWaitingForUserAction) break;
            } while (true);

            var state = Topas.WavelengthService.GetOutput ();
            if (state.IsWaitingForUserAction) {
                //inform user what needs to be done
                Console.WriteLine ("User actions required. Press any key to confirm.");
                foreach (var item in state.Messages.Where (x => x.IsNew)) {
                    Console.WriteLine (item.Text + (item.Image == null ? "" : ", image name: " + item.Image));
                }
                Console.ReadKey ();//wait foir user confirmation
                //tell the device that required actions have been performed. If shutter was open before setting wavelength it will be opened again
                Topas.WavelengthService.FinishWavelengthSettingAfterUserActions (new FinishSettingWavelengthOptions () { RestoreShutter = true });
            }
            Console.WriteLine ("Done setting wavelength");
        }

        /// <summary>
        /// Shows how to move single motor to desired position
        /// </summary>
        /// <param name="topas"></param>
        /// <param name="motor"></param>
        public void TweakMotorPosition (MotorData motor) {
            if (motor == null) throw new ArgumentNullException (nameof (motor), $"{nameof (motor)} is null.");
            Console.WriteLine (@"Press Up/Down arrow keys to move motor " + motor.Title + ". Press Escape to finish motor position tweaking.");
            var motorIndex = motor.Index;
            do {
                var key = Console.ReadKey (true);
                switch (key.Key) {
                    case ConsoleKey.Escape:
                        return;

                    case ConsoleKey.UpArrow:
                        var current = Topas.MotorsService.GetMotor (motorIndex).TargetPosition;
                        Topas.MotorsService.SetTargetPosition (motorIndex, current + 8);//steps, if you want to use units use SetMotorTargetPositionInUnits
                        break;
                    case ConsoleKey.DownArrow:
                        Topas.MotorsService.SetTargetPositionRelative (motorIndex, -8);//functionality code to UpArrow
                        break;

                    default:
                        Console.WriteLine ("Invalid key. Use Escape to stop motor position adjustment, Up and Down arrows to move motor.");
                        break;
                }

            } while (true);
        }
    }
}
