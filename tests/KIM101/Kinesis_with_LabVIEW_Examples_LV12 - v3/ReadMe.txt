The Kinesis LabVIEW Website examples are LabVIEW 2012 compatible examples intended to be used to rapidly connect and control key Thorlabs
devices. They are not intended to be a demonstration of good programming practices. Many of the
normal programming techniques have not been included for the sake of simplicity.

For tips on building your own VIs with Thorlabs Motion Control Hardware, please see our LabVIEW Guide here.
https://www.thorlabs.com/newgrouppage9.cfm?objectgroup_id=10285

1. Install Kinesis from the Thorlabs website here.
https://www.thorlabs.com/software_pages/ViewSoftwarePage.cfm?Code=Motion_Control

Ensure that the version/DLLS you are using are of the correct bit type depending on your version of LabVIEW & your type of Operating System.
i.e. 32-bit or 64-bit.

2. For the example VIs to successfully run you will need to manually copy all of the component DLLs
from your Kineses install folder & drop them into the "Kinesis LabVIEW Examples" folder. 
You can also use Thorlabs.MotionControl.Kinesis.DLLutility included with your Kinesis Software installation to copy these DLLs into your project.

3. Open the "Kinesis with LabVIEW Examples" LabVIEW Project.

4. Within the Project Explorer, select File > Open to select the VI you wish to open & run. 
This will ensure that the WinForms UI from Thorlabs.MotionControl.Controls.dll is correctly loaded.

