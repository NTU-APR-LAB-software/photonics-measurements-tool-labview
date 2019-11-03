using System;
using System.Windows.Forms;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericPiezoCLI.Settings;
using Thorlabs.MotionControl.KCube.StrainGaugeCLI;

namespace KSG_KCubeStrainGaugeReader
{
    public partial class MainForm : Form
    {
        private KCubeStrainGauge _kCubeStrainGauge = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void buttonConnect_Click(object sender, System.EventArgs e)
        {

            if (_kCubeStrainGauge != null)
            {
                MessageBox.Show("Device already connected");
                return;
            }

            const string serialNumber = "59000160";

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

                _kCubeStrainGauge = KCubeStrainGauge.CreateKCubeStrainGauge(serialNumber);

                // Establish a connection with the device.
                _kCubeStrainGauge.Connect(serialNumber);

                // Wait for the device settings to initialize. We ask the device to
                // throw an exception if this takes more than 5000ms (5s) to complete.
                _kCubeStrainGauge.WaitForSettingsInitialized(5000);

                // This starts polling the device at intervals of 250ms (0.25s).
                _kCubeStrainGauge.StartPolling(250);

                // Initialize the DeviceUnitConverter object required for real world
                // unit parameters.
                _kCubeStrainGauge.GetStrainGaugeConfiguration(serialNumber);

                // We are now able to enable the device for commands.
                _kCubeStrainGauge.EnableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to device\n" + ex);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_kCubeStrainGauge == null)
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
                _kCubeStrainGauge.ShutDown();

                _kCubeStrainGauge = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disconnect from device\n" + ex);
            }
        }

        private void buttonGetReading_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // As well as retrieving the reading we're going to give it some
                // context by retrieving the display mode.
                labelGetReadingResponse.Text = "mode = " + _kCubeStrainGauge.Status.ReadingMode + "\n" +
                                               "reading = " + _kCubeStrainGauge.Status.Reading;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get a reading\n" + ex);
            }
        }

        private void buttonSetModeToVoltage_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _kCubeStrainGauge.SetDisplayMode(DisplayModeSettings.TSGDisplayModes.Voltage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set display mode to 'Voltage'\n" + ex);
            }
        }

        private void buttonSetModeToPosition_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _kCubeStrainGauge.SetDisplayMode(DisplayModeSettings.TSGDisplayModes.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set display mode to 'Position'\n" + ex);
            }
        }

        private void buttonSetModeToForce_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _kCubeStrainGauge.SetDisplayMode(DisplayModeSettings.TSGDisplayModes.Force);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set display mode to 'Force'\n" + ex);
            }
        }

        #endregion
    }
}
