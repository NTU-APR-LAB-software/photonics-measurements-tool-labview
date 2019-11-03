using System;
using System.Windows.Forms;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.KCube.PositionAlignerCLI;

namespace KPA_KCubePositionAligner
{
    public partial class MainForm : Form
    {
        private KCubePositionAligner _kCubePositionAligner = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (_kCubePositionAligner != null)
            {
                MessageBox.Show("Device already connected");
                return;
            }

            const string serialNumber = "69250117";

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

                _kCubePositionAligner = KCubePositionAligner.CreateKCubePositionAligner(serialNumber);

                // Establish a connection with the device.
                _kCubePositionAligner.Connect(serialNumber);

                // Wait for the device settings to initialize. We ask the device to
                // throw an exception if this takes more than 5000ms (5s) to complete.
                _kCubePositionAligner.WaitForSettingsInitialized(5000);

                // This starts polling the device at intervals of 250ms (0.25s).
                _kCubePositionAligner.StartPolling(250);

                // Initialize the DeviceUnitConverter object required for real world
                // unit parameters.
                _kCubePositionAligner.GetPositionAlignerConfiguration(serialNumber);

                // We are now able to enable the device for commands.
                _kCubePositionAligner.EnableDevice();

                // Place the device in OpenLoop mode. The position will be monitored
                // but the X DIFF and Y DIFF outputs will remain under our control.
                _kCubePositionAligner.SetOperatingMode(PositionAlignerStatus.OperatingModes.OpenLoop, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to device\n" + ex);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_kCubePositionAligner == null)
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
                _kCubePositionAligner.ShutDown();

                _kCubePositionAligner = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disconnect from device\n" + ex);
            }
        }

        private void buttonGetPosition_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                double xPos = _kCubePositionAligner.Status.PositionDifference.X;
                double yPos = _kCubePositionAligner.Status.PositionDifference.Y;

                labelGetPositionResponse.Text = "x = " + xPos + "\n" + 
                                                "y = " + yPos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get position\n" + ex);
            }
        }

        private void buttonSetOutputsToZeros_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Set both the X DIFF and YDIFF outputs to 0.
                _kCubePositionAligner.SetPosition(new XYPosition(0, 0));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set requested ouput levels\n" + ex);
            }
        }

        private void buttonSetOutputs_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Set both the X DIFF and YDIFF outputs to 5 and -3.5 respectively.
                _kCubePositionAligner.SetPosition(new XYPosition(5, -3.5));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set requested ouput levels\n" + ex);
            }
        }

        #endregion
    }
}
