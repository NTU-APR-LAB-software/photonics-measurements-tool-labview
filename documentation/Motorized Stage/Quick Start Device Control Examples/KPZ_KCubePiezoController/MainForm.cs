using System;
using System.Globalization;
using System.Windows.Forms;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.KCube.PiezoCLI;

namespace KPZ_KCubePiezoController
{
    public partial class MainForm : Form
    {
        private KCubePiezo _kCubePiezo = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void buttonConnect_Click(object sender, System.EventArgs e)
        {
            if (_kCubePiezo != null)
            {
                MessageBox.Show("Device already connected");
                return;
            }

            const string serialNumber = "29500610";

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

                _kCubePiezo = KCubePiezo.CreateKCubePiezo(serialNumber);

                // Establish a connection with the device.
                _kCubePiezo.Connect(serialNumber);

                // Wait for the device settings to initialize. We ask the device to
                // throw an exception if this takes more than 5000ms (5s) to complete.
                _kCubePiezo.WaitForSettingsInitialized(5000);

                // Initialize the DeviceUnitConverter object required for real world
                // unit parameters.
                _kCubePiezo.GetPiezoConfiguration(serialNumber);

                // This starts polling the device at intervals of 250ms (0.25s).
                _kCubePiezo.StartPolling(250);

                // We are now able to enable the device for commands.
                _kCubePiezo.EnableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to device\n" + ex);
            }
        }

        private void buttonDisconnect_Click(object sender, System.EventArgs e)
        {
            if (_kCubePiezo == null)
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
                _kCubePiezo.ShutDown();

                _kCubePiezo = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disconnect from device\n" + ex);
            }
        }
        
        private void buttonGetHVOUT_Click(object sender, System.EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                decimal reading = _kCubePiezo.GetOutputVoltage();
                labelGetHVOUTResult.Text = reading.ToString(CultureInfo.CurrentUICulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get a reading\n" + ex);
            }
        }

        private void buttonSetHVOUTToZero_Click(object sender, System.EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _kCubePiezo.SetOutputVoltage(decimal.Zero);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set HV OUT\n" + ex);
            }
        }

        private void buttonSetHVOUTToTen_Click(object sender, System.EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                _kCubePiezo.SetOutputVoltage(10m);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set HV OUT\n" + ex);
            }
        }

        #endregion
    }
}
