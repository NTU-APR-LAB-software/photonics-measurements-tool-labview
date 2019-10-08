

import time
import random
import requests
import sys
import msvcrt
from Topas4Locator import Topas4Locator



def main():
    serialNumber = "00666" #enter serial number or your own device here
    example = Topas4Example(serialNumber)
    example.run()


class Topas4Example:
    baseAddress = None

    def __init__(self, serialNumber):
        locator = Topas4Locator()
        availableDevices = locator.locate()
        match = next((obj for obj in availableDevices if obj['SerialNumber']==serialNumber), None)
        if match is None:
            print ('Device with serial number %s not found' % serialNumber)
        else:
            self.baseAddress = match['PublicApiRestUrl_Version0']

    def run(self):
       if (self.baseAddress is None):
           return
       self.getCalibrationInfoAndSetWavelength()
       time.sleep(0.2)
       self.changeShutter()
       availableMotors = self.get('/Motors/AllProperties').json()['Motors']
       if(len(availableMotors) > 0):
          self.tweakMotorPositions(availableMotors[0])


    def put(self, url, data):
        return requests.put(self.baseAddress + url, json =data)
    def post(self, url, data):
        return requests.post(self.baseAddress + url, json =data)
    def get(self, url):
        return requests.get(self.baseAddress + url)
    



    def getCalibrationInfoAndSetWavelength(self):
        """Get basic calibration info and set random wavelength using random interaction"""
        interactions = self.get('/Optical/WavelengthControl/ExpandedInteractions').json()
        print("Available interactions:")
        for item in interactions:
           print(item['Type'] + " %d - %d nm" % (item['OutputRange']['From'], item['OutputRange']['To']))
        if len(interactions) > 0:
          interaction = interactions[random.randint(0,len(interactions) - 1)] #set wavelength using random interaction
          #wavelength is selected randomly too, to be in valid range for that
                                                                                       #interaction
          wavelengthToSet = interaction['OutputRange']['From'] + (interaction['OutputRange']['To'] - interaction['OutputRange']['From']) * random.uniform(0,1)
          print("setting wavelength %.4f nm using interaction %s" % (wavelengthToSet, interaction['Type']))
          response = self.put('/Optical/WavelengthControl/SetWavelength', { 'Interaction':interaction['Type'], 'Wavelength':wavelengthToSet })
          #if I don't care about interaction used:
          #response =self.put('/Optical/WavelengthControl/SetWavelengthUsingAnyInteraction',wavelengthToSet)
          self.waitTillWavelengthIsSet()
        else:
            print("There are no calibrated interactions")

    def changeShutter(self):
        isShutterOpen = self.get('/ShutterInterlock/IsShutterOpen').json()
        line = input(r"Do you want to " + ("close" if isShutterOpen  else "open") + r" shutter? (Y\N)").upper()
        if line == "Y" or line == "YES":
           self.put('/ShutterInterlock/OpenCloseShutter', not isShutterOpen)
 

   
    def waitTillWavelengthIsSet(self):
       """
       Waits till wavelength setting is finished.  If user needs to do any manual
       operations (e.g.  change wavelength separator), inform him/her and wait for confirmation.
       """
       while(True):
        s = self.get('/Optical/WavelengthControl/Output').json()
        sys.stdout.write("\r %d %% done" % (s['WavelengthSettingCompletionPart'] * 100.0))
        if s['IsWavelengthSettingInProgress'] == False or s['IsWaitingForUserAction']:
            break
       state = self.get('/Optical/WavelengthControl/Output').json()
       if state['IsWaitingForUserAction']:
          print("\nUser actions required. Press enter key to confirm.")
          #inform user what needs to be done
          for item in state['Messages']:
             print(item['Text'] + ' ' + ('' if item['Image'] is None else ', image name: ' + item['Image']))
          sys.stdin.read(1)#wait for user confirmation
          # tell the device that required actions have been performed.  If shutter was open before setting wavelength it will be opened again
          self.put('/Optical/WavelengthControl/FinishWavelengthSettingAfterUserActions', {'RestoreShutter':True})
       print("Done setting wavelength")


    def tweakMotorPositions(self, motor):
        """Shows how to move single motor to desired position and read current position"""
        print(r"Press Up/Down arrow keys to move motor " + motor['Title'] + ". Press Escape to finish motor position tweaking.")
        motorIndex = motor['Index']
        while (True):
             key = ord(msvcrt.getch())
             if key == 27: #ESC
                return
             elif key == 224: #Special keys
                key = ord(msvcrt.getch())
                if key == 72: #Up arrow
                    current = self.get('/Motors/TargetPosition?id=%i' % motorIndex).json()
                    self.put('/Motors/TargetPosition?id=%i' % motorIndex, current + 8)
                    #steps, if you want to use units use TargetPositionInUnits
                elif key == 80: #Down arrow
                    self.put('/Motors/TargetPositionRelative?id=%i' % motorIndex, -8)
                    #equivalent functionality to UpArrow
                else:
                    print("Invalid key. Use Escape to stop motor position adjustment, Up and Down arrows to move motor.")
             else:
                print("Invalid key. Use Escape to stop motor position adjustment, Up and Down arrows to move motor.")





if __name__ == "__main__":
    main()



