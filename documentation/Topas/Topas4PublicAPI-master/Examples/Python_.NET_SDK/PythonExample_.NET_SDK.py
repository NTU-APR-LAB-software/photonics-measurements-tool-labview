

import clr
import sys
import msvcrt
import time
clr.AddReference(r"..\..\NET_SDK\Topas4Lib") #this is a reference to Topas4Lib.dll, which is located two directories up

from Topas4Lib import TopasDevice
import Mint
import random


def main():
   serialNumber = "00666" #enter serial number or your own device here
   example = Topas4SDKExample(serialNumber)
   example.run()


class Topas4SDKExample:
    topas = None

    def __init__(self, serialNumber):
        self.topas = TopasDevice.FindTopasDevice(serialNumber)
        if self.topas is None:
            print ('Device with serial number %s not found' % serialNumber)
        

    def run(self):
      if (self.topas is None):
        return
      self.getCalibrationInfoAndSetWavelength()
      time.sleep(0.2)
      self.changeShutter()
    
      availableMotors = self.topas.MotorsService.GetAllProperties().Motors
      if(availableMotors.Count > 0):
        self.tweakMotorPositions(availableMotors[0])

    def getCalibrationInfoAndSetWavelength(self):
       """Get basic calibration info and set random wavelength using random interaction"""
       interactions = self.topas.WavelengthService.GetExpandedInteractions()
       print("Available interactions:")
       for item in interactions:
           print(item.Type + " %d - %d nm" % (item.OutputRange.From, item.OutputRange.To))
       if interactions.Count > 0:
          interaction = interactions[random.randint(0,interactions.Count - 1)] #set wavelength using random interaction
          #wavelength is selected randomly too, to be in valid range for that
                                                                                        #interaction
          wavelengthToSet = interaction.OutputRange.From + interaction.OutputRange.Diff * random.uniform(0,1)
          print("setting wavelength %.4f nm using interaction %s" % (wavelengthToSet, interaction.Type))
          self.topas.SetWavelength(wavelengthToSet, interaction.Type)
          #if I don't care about interaction used:
          #self.topas.WavelengthService.SetOutputAnyInteraction
          self.waitTillWavelengthIsSet()
       else:
          print("There are no calibrated interactions")


    def changeShutter(self):
        isShutterOpen = self.topas.ShutterService.GetIsShutterOpen()
        line = input(r"Do you want to " + ("close" if isShutterOpen  else "open") + r" shutter? (Y\N)").upper()
        if line == "Y" or line == "YES":
           self.topas.ShutterService.SetOpenCloseShutter(not isShutterOpen) 

    
    def waitTillWavelengthIsSet(self):
       """
       Waits till wavelength setting is finished.  If user needs to do any manual
       operations (e.g.  change wavelength separator), inform him/her and wait for confirmation.
       """
       while(True):
            s = self.topas.WavelengthService.GetOutput()
            sys.stdout.write("\r %d %% done" % (s.WavelengthSettingCompletionPart * 100.0))
            if s.IsWavelengthSettingInProgress == False or s.IsWaitingForUserAction:
                break
       state = self.topas.WavelengthService.GetOutput()
       if state.IsWaitingForUserAction:
          print("\nUser actions required. Press enter key to confirm.")
          #inform user what needs to be done
          for item in state.Messages:
             print(item.Text + " " + ("" if item.Image is None else ", image name: " + item.Image))
          sys.stdin.read(1)#wait for user confirmation
          options = Mint.Services.FinishSettingWavelengthOptions()
          options.RestoreShutter = True
          # tell the device that required actions have been performed.  If
          # shutter was open before setting wavelength it will be opened again
          self.topas.WavelengthService.FinishWavelengthSettingAfterUserActions(options)
       print("Done setting wavelength")


    def tweakMotorPositions(self, motor):
        """Shows how to move single motor to desired position and read current position"""
        print(r"Press Up/Down arrow keys to move motor " + motor.Title + ". Press Escape to finish motor position tweaking.")
        while (True):
             key = ord(msvcrt.getch())
             if key == 27: #ESC
                return
             elif key == 224: #Special keys
                key = ord(msvcrt.getch())
                if key == 72: #Up arrow
                    current = self.topas.MotorsService.GetMotor(motor.Index).TargetPosition
                    self.topas.MotorsService.SetTargetPosition(motor.Index, current + 8)
                    #steps, if you want to use units use
                    #SetMotorTargetPositionInUnits
                elif key == 80: #Down arrow
                    self.topas.MotorsService.SetTargetPositionRelative(motor.Index, -8)
                    #equivalent functionality to UpArrow
                else:
                    print("Invalid key. Use Escape to stop motor position adjustment, Up and Down arrows to move motor.")
             else:
                print("Invalid key. Use Escape to stop motor position adjustment, Up and Down arrows to move motor.")





if __name__ == "__main__":
    main()



   