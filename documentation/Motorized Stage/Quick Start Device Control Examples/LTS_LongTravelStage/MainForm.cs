using System;
using System.Windows.Forms;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.IntegratedStepperMotorsCLI;

namespace LTS_LongTravelStage
{
    public partial class MainForm : Form
    {
        private LongTravelStage _longTravelStage = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (_longTravelStage != null)
            {
                MessageBox.Show("Device already connected");
                return;
            }

            const string serialNumber = "45848872";

            // All of this operation has been placed inside a single "catch-all"
            // exception handler. This is to reduce the size of the example code.
            // Normally you would have a try...catch per API call and catch the
            // specific exceptions that could be thrown (details of which can be
            // found in the Kinesis .NET API document).
            try
            {
                // Instructs the DeviceManager to build and maintain the list of
                // devices connected.
                DeviceManagerCLI.BuildDeviceList();

                _longTravelStage = LongTravelStage.CreateLongTravelStage(serialNumber);

                // Establish a connection with the device.
                _longTravelStage.Connect(serialNumber);

                // Wait for the device settings to initialize. We ask the device to
                // throw an exception if this takes more than 5000ms (5s) to complete.
                _longTravelStage.WaitForSettingsInitialized(5000);

                // Initialize the DeviceUnitConverter object required for real world
                // unit parameters.
                _longTravelStage.LoadMotorConfiguration(_longTravelStage.DeviceID);

                // This starts polling the device at intervals of 250ms (0.25s).
                _longTravelStage.StartPolling(250);

                // We are now able to enable the device for commands.
                _longTravelStage.EnableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to device\n" + ex);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_longTravelStage == null)
            {
                MessageBox.Show("Not connected to device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Shuts down this device and frees any resources it is using.
                _longTravelStage.ShutDown();

                _longTravelStage = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disconnect from device\n" + ex);
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We pass in a wait timeout of zero to indicates we don't care how
                // long it takes to perform the home operation.
                _longTravelStage.Home(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to return device to home position\n" + ex);
            }
        }

        private void buttonMoveToZero_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Move the device to position 0. We specify 0 as the wait timeout
                // as we don't care how long it takes.
                _longTravelStage.MoveTo(0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to move to position 0\n" + ex);
            }
        }

        private void buttonMoveToFifty_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the move operation
                // takes longer than 10000ms (10s).
                _longTravelStage.MoveTo(50, 10000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to move to position 50\n" + ex);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the operation takes
                // longer than 1000ms (1s).
                _longTravelStage.Stop(1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to stop\n" + ex);
            }
        }

        #endregion
    }
}
