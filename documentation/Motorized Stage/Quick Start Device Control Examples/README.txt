
NOTES

These Quick Start examples are intended to be used to rapidly connect and control key Thorlabs
devices. They are not intended to be a demonstration of good programming practices. Many of the
normal programming techniques have been omitted for the sake of simplicity.

For the example applications to compile you will need to manually copy the DLLs
from your Kineses install folder to the "Shared Libraries" folder.

You do not need to copy all of the DLLs, however, to get up and running quickly we
recommend you do.

If you wish to be more selective about which DLLs you copy (or for more information
generally) please refer to the appropriate sections of the Kinesis .Net API Help document.


UPDATE HISTORY

29th Oct 2018 - Update history now included.
              - BSC_BenchtopStepper Motor:
                  - 'GetMotorConfiguration' replaced with 'LoadMotorConfiguration'.
                  - Home and Move timeout now 20 seconds.
                  - Bug fix: Wrong channel being checked for null in 'buttonChannelTwoMoveToZero_Click'.
              - KDC_KCubeDCServoMotor:
                  - 'GetMotorConfiguration' replaced with 'LoadMotorConfiguration'.
              - LTS_LongTravelStage:
                  - 'GetMotorConfiguration' replaced with 'LoadMotorConfiguration'.

20th Jul 2017 - Initial release.