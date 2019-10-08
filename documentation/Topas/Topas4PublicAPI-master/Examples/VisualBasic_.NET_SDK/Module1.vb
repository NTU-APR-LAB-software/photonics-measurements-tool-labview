Imports VisualBasic_.NET_SDK.Topas4LibExample

Module Module1

    Sub Main()
        Dim serialNumber = "00666" 'change to actual serial number of your own device.
        Dim example = New Topas4SDKExample(serialNumber)
        example.Run()
    End Sub

End Module
