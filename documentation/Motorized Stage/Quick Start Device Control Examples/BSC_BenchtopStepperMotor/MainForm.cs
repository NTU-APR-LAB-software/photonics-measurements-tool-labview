using System;
using System.Windows.Forms;
using Thorlabs.MotionControl.Benchtop.StepperMotorCLI;
using Thorlabs.MotionControl.DeviceManagerCLI;

namespace BSC_BenchtopStepperMotor
{
    public partial class MainForm : Form
    {
        const string SerialNumber = "70811768";
        
        private BenchtopStepperMotor _benchtopStepperMotor = null;
        private StepperMotorChannel _stepperMotorChannelOne = null;
        private StepperMotorChannel _stepperMotorChannelTwo = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Events Handlers

        #region Channel 1

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (_benchtopStepperMotor != null)
            {
                MessageBox.Show("Device already connected");
                return;
            }

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

                _benchtopStepperMotor = BenchtopStepperMotor.CreateBenchtopStepperMotor(SerialNumber);

                // Establish a connection with the device.
                _benchtopStepperMotor.Connect(SerialNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to device\n" + ex);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_benchtopStepperMotor == null)
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
                _benchtopStepperMotor.ShutDown();

                _benchtopStepperMotor = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disconnect from device\n" + ex);
            }
        }

        private void buttonChannelOneConnect_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelOne != null)
            {
                MessageBox.Show("Device channel 1 already connected");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _stepperMotorChannelOne = _benchtopStepperMotor.GetChannel(1);

                // Wait for the device channel settings to initialize. We ask the
                // device to throw an exception if this takes more than 5000ms (5s)
                // to complete.
                _stepperMotorChannelOne.WaitForSettingsInitialized(5000);

                // Initialize the DeviceUnitConverter object required for real world
                // unit parameters.
                _stepperMotorChannelOne.LoadMotorConfiguration(_stepperMotorChannelOne.DeviceID);

                // This starts polling the device channel at intervals of 250ms (0.25s).
                _stepperMotorChannelOne.StartPolling(250);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to channel 1 on device\n" + ex);
            }
        }

        private void buttonChannelOneDisconnect_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelOne == null)
            {
                MessageBox.Show("Not connected to channel 1 on device");
                return;
            }

            _stepperMotorChannelOne = null;
        }

        private void buttonChannelOneEnable_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelOne == null)
            {
                MessageBox.Show("Not connected to channel 1 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _stepperMotorChannelOne.EnableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to enable channel 1 on device\n" + ex);
            }
        }

        private void buttonChannelOneDisable_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelOne == null)
            {
                MessageBox.Show("Not connected to channel 1 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _stepperMotorChannelOne.DisableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disable channel 1 on device\n" + ex);
            }
        }

        private void buttonChannelOneHome_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelOne == null)
            {
                MessageBox.Show("Not connected to channel 1 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the operation takes
                // longer than 20,000ms (20s).
                _stepperMotorChannelOne.Home(20000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to home channel 1 on device\n" + ex);
            }
        }

        private void buttonChannelOneMoveToZero_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelOne == null)
            {
                MessageBox.Show("Not connected to channel 1 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the operation takes
                // longer than 20,000ms (20s).
                _stepperMotorChannelOne.MoveTo(decimal.Zero, 20000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to move channel 1 on device\n" + ex);
            }
        }

        private void buttonChannelOneMoveToTen_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelOne == null)
            {
                MessageBox.Show("Not connected to channel 1 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the operation takes
                // longer than 20,000ms (20s).
                _stepperMotorChannelOne.MoveTo(10m, 20000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to move channel 1 on device\n" + ex);
            }
        }

        #endregion

        #region Channel 2

        private void buttonChannelTwoConnect_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelTwo != null)
            {
                MessageBox.Show("Device channel 2 already connected");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _stepperMotorChannelTwo = _benchtopStepperMotor.GetChannel(2);

                // Wait for the device channel settings to initialize. We ask the
                // device to throw an exception if this takes more than 5000ms (5s)
                // to complete.
                _stepperMotorChannelTwo.WaitForSettingsInitialized(5000);

                // Initialize the DeviceUnitConverter object required for real world
                // unit parameters.
                _stepperMotorChannelTwo.LoadMotorConfiguration(_stepperMotorChannelTwo.DeviceID);

                // This starts polling the device channel at intervals of 250ms (0.25s).
                _stepperMotorChannelTwo.StartPolling(250);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to channel 2 on device\n" + ex);
            }
        }

        private void buttonChannelTwoDisconnect_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelTwo == null)
            {
                MessageBox.Show("Not connected to channel 2 on device");
                return;
            }

            _stepperMotorChannelTwo = null;
        }

        private void buttonChannelTwoEnable_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelTwo == null)
            {
                MessageBox.Show("Not connected to channel 2 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _stepperMotorChannelTwo.EnableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to enable channel 2 on device\n" + ex);
            }
        }

        private void buttonChannelTwoDisable_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelTwo == null)
            {
                MessageBox.Show("Not connected to channel 2 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _stepperMotorChannelTwo.DisableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disable channel 2 on device\n" + ex);
            }
        }

        private void buttonChannelTwoHome_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelTwo == null)
            {
                MessageBox.Show("Not connected to channel 2 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the operation takes
                // longer than 20,000ms (20s).
                _stepperMotorChannelTwo.Home(20000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to home channel 2 on device\n" + ex);
            }
        }

        private void buttonChannelTwoMoveToZero_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelTwo == null)
            {
                MessageBox.Show("Not connected to channel 2 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the operation takes
                // longer than 20,000ms (20s).
                _stepperMotorChannelTwo.MoveTo(decimal.Zero, 20000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to move channel 2 on device\n" + ex);
            }
        }

        private void buttonChannelTwoMoveToTen_Click(object sender, EventArgs e)
        {
            if (_stepperMotorChannelTwo == null)
            {
                MessageBox.Show("Not connected to channel 2 on device");
                return;
            }

            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // We ask the device to throw an exception if the operation takes
                // longer than 20,000ms (20s).
                _stepperMotorChannelTwo.MoveTo(10m, 20000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to move channel 2 on device\n" + ex);
            }
        }

        #endregion

        #endregion
    }
}
