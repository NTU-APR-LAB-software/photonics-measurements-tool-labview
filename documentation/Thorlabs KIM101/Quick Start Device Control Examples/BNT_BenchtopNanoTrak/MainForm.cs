using System;
using System.Globalization;
using System.Windows.Forms;
using Thorlabs.MotionControl.Benchtop.NanoTrakCLI;
using Thorlabs.MotionControl.DeviceManagerCLI;
using Thorlabs.MotionControl.GenericNanoTrakCLI;

namespace BNT_BenchtopNanoTrak
{
    public partial class MainForm : Form
    {
        private BenchtopNanoTrak _benchtopNanoTrak = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (_benchtopNanoTrak != null)
            {
                MessageBox.Show("Device already connected");
                return;
            }

            const string serialNumber = "22807843";

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

                _benchtopNanoTrak = BenchtopNanoTrak.CreateBenchtopNanoTrak(serialNumber);

                // Establish a connection with the device.
                _benchtopNanoTrak.Connect(serialNumber);

                // Wait for the device settings to initialize. We ask the device to
                // throw an exception if this takes more than 5000ms (5s) to complete.
                _benchtopNanoTrak.WaitForSettingsInitialized(5000);

                // Initialize the GetNanoTrakConfiguration object required for real
                // world unit parameters.
                _benchtopNanoTrak.GetNanoTrakConfiguration(serialNumber);

                // This starts polling the device at intervals of 250ms (0.25s).
                _benchtopNanoTrak.StartPolling(250);

                // We are now able to enable the device for commands.
                _benchtopNanoTrak.EnableDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect to device\n" + ex);
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (_benchtopNanoTrak == null)
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
                _benchtopNanoTrak.ShutDown();

                _benchtopNanoTrak = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to disconnect from device\n" + ex);
            }
        }

        private void buttonGetMode_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Retrieve and display the current operating mode of the Benchtop
                // NanaTrak.
                NanoTrakStatus.OperatingModes mode = _benchtopNanoTrak.GetMode();

                labelCurrentMode.Text = mode.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get mode\n" + ex);
            }
        }

        private void buttonSetModeToLatched_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Set the operating mode to 'latched'. This will disable scanning
                // and hold both HV outputs at their current level.
                _benchtopNanoTrak.SetMode(NanoTrakStatus.OperatingModes.Latch);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set mode\n" + ex);
            }
        }

        private void buttonSetModeToTracking_Click(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Set the operating mode to 'tracking'. This will permit the
                // NanoTrak to make changes to the HV output levels in order that
                // the maximum signal strength can be located and maintained.
                _benchtopNanoTrak.SetMode(NanoTrakStatus.OperatingModes.Tracking);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set mode\n" + ex);
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
                // Read and display the current signal level.
                TIAReading reading = _benchtopNanoTrak.GetReading();

                labelGetReadingResponse.Text = reading.AbsoluteReading.ToString(CultureInfo.CurrentUICulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to get reading\n" + ex);
            }
        }

        private void buttonSetHomeCirclePosition(object sender, EventArgs e)
        {
            // All of this operation has been placed inside a "catch-all" exception
            // handler. Normally you would catch the more specific exceptions that
            // the API call might throw (details of which can be found in the
            // Kinesis .NET API document).
            try
            {
                // Set the scan circle home position.
                _benchtopNanoTrak.SetCircleHomePosition(new HVPosition(0.005, 0.002));
                _benchtopNanoTrak.HomeCircle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to set the scan circle home position\n" + ex);
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
                // Instruct the NanoTrak to return the scan circle to its home position.
                _benchtopNanoTrak.HomeCircle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to return to scan circle home position\n" + ex);
            }
        }

        #endregion

    }
}
