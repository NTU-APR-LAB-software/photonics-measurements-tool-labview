
Imports Mint.Services
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports Topas4Lib

Namespace Topas4LibExample
	Class Topas4SDKExample

		Private ReadOnly Property Topas() As TopasDevice
		Public ReadOnly Property SerialNumber() As String



		Public Sub New(serialNumber__1 As String)
			If String.IsNullOrEmpty(serialNumber__1) Then
				Throw New ArgumentException("{nameof (serialNumber)} is null or empty.", nameof(serialNumber__1))
			End If
			SerialNumber = serialNumber__1

			'location of all available devices, just for demonstration
			Dim devices = Mint.Services.MintServicesClientHelpers.LocateDevices()
			For Each item In devices
				Console.WriteLine("SN: " & item.SerialNumber & ", address: " & item.PublicApiRestUrl_Version0 & ", has access right? " & item.CallerHasAccessRights)
			Next

			Topas = TopasDevice.FindTopasDevice(serialNumber__1)
			If Topas Is Nothing Then
				Console.WriteLine((Convert.ToString("Device with serial number ") & SerialNumber) + " not found.")
			End If
		End Sub


		Public Sub Run()

			If Topas Is Nothing Then
				Console.WriteLine("Press any key to exit")
				Console.ReadKey()
				Return
			End If


			GetCalibrationInfoAndSetWavelength()

			Thread.Sleep(200)
			ChangeShutter()

			Dim availableMotors = Topas.MotorsService.GetAllProperties().Motors
			If availableMotors.Count > 0 Then

				TweakMotorPosition(availableMotors.First())
			End If


			Console.WriteLine("Press any key to exit")
			Console.ReadKey()
		End Sub

		Public Sub ChangeShutter()
			Dim isShutterOpen = Topas.ShutterService.GetIsShutterOpen()
			Console.WriteLine("Do you want to " + (If(isShutterOpen, "close", "open")) + " shutter? (Y\N)")
			Dim answer = Console.ReadLine()
			If answer.ToUpperInvariant() = "Y" OrElse answer.ToUpperInvariant() = "YES" Then
				Topas.ShutterService.SetOpenCloseShutter(Not isShutterOpen) 'invert previous state
			End If
		End Sub



		''' <summary>
		''' Get basic calibration info and set random wavelength using random interaction
		''' </summary>
		Public Sub GetCalibrationInfoAndSetWavelength()
			Dim interactions = Topas.WavelengthService.GetExpandedInteractions()
			Console.WriteLine("Available interactions:")
			For Each item In interactions
				Console.WriteLine(item.Type + " " + item.OutputRange.From.ToString() + " - " + item.OutputRange.To.ToString() + " nm")
			Next

			If interactions.Count > 0 Then
				Dim random = New Random()
				Console.WriteLine("")
				Dim interaction = interactions(random.Next(0, interactions.Count))
				'set wavelength using random interaction
				'wavelength is selected randomly too, to be in valid range for that interaction
				Dim wavelengthToSet = interaction.OutputRange.From + random.NextDouble() * interaction.OutputRange.Diff
				Console.WriteLine("setting wavelength " + wavelengthToSet.ToString() + " using interaction " + interaction.Type)
				Topas.SetWavelength(wavelengthToSet, interaction.Type)

				'if I don't care about interaction used:
				'Topas.WavelengthService.SetOutputAnyInteraction (wavelengthToSet);

				WaitTillWavelengthIsSet()
			Else
				Console.WriteLine("There are no calibrated interactions.")
			End If
		End Sub


		''' <summary>
		''' Waits till wavelength setting is finished. If user needs to do any manual operations (e.g. chnge wavelength separator), inform him/her and wait for confirmation.
		''' </summary>
		''' <param name="topas"></param>
		Public Sub WaitTillWavelengthIsSet()
			Do
				Dim s = Topas.WavelengthService.GetOutput()
				'wait till wavelength setting is done (i.e. motors are in place) or failed
				Console.Write(vbCr + (s.WavelengthSettingCompletionPart * 100.0).ToString("N2") + " % done     ")
				If s.IsWavelengthSettingInProgress = False OrElse s.IsWaitingForUserAction Then
					Exit Do
				End If
			Loop While True

			Dim state = Topas.WavelengthService.GetOutput()
			If state.IsWaitingForUserAction Then
				'inform user what needs to be done
				Console.WriteLine("User actions required. Press any key to confirm.")
				For Each item In state.Messages.Where(Function(x) x.IsNew)
					Console.WriteLine(item.Text & (If(item.Image Is Nothing, "", ", image name: " & item.Image)))
				Next
				Console.ReadKey()
				'wait foir user confirmation
				'tell the device that required actions have been performed. If shutter was open before setting wavelength it will be opened again
                Dim options = New FinishSettingWavelengthOptions()
                    options.RestoreShutter = True
				Topas.WavelengthService.FinishWavelengthSettingAfterUserActions(options)
			End If
			Console.WriteLine("Done setting wavelength")
		End Sub

		''' <summary>
		''' Shows how to move single motor to desired position
		''' </summary>
		''' <param name="topas"></param>
		''' <param name="motor"></param>
		Public Sub TweakMotorPosition(motor As MotorData)
			If motor Is Nothing Then
				Throw New ArgumentNullException(nameof(motor), "{nameof (motor)} is null.")
			End If
			Console.WriteLine("Press Up/Down arrow keys to move motor " & motor.Title & ". Press Escape to finish motor position tweaking.")
			Dim motorIndex = motor.Index
			Do
				Dim key = Console.ReadKey(True)
				Select Case key.Key
					Case ConsoleKey.Escape
						Return

					Case ConsoleKey.UpArrow
						Dim current = Topas.MotorsService.GetMotor(motorIndex).TargetPosition
						Topas.MotorsService.SetTargetPosition(motorIndex, current + 8)
						'steps, if you want to use units use SetMotorTargetPositionInUnits
						Exit Select
					Case ConsoleKey.DownArrow
						Topas.MotorsService.SetTargetPositionRelative(motorIndex, -8)
						'functionality code to UpArrow
						Exit Select
					Case Else

						Console.WriteLine("Invalid key. Use Escape to stop motor position adjustment, Up and Down arrows to move motor.")
						Exit Select

				End Select
			Loop While True
		End Sub
	End Class
End Namespace

