'  Declare a variable to hold an IE object
Dim objIE

'  Grab an IE automation object
Set objIE = WScript.CreateObject("InternetExplorer.Application", "objIE_")

'  Navigate to a webpage
objIE.Navigate "http://www.bing.com"

'  Set the browser as visible
objIE.Visible = 1

'  Pause script with a message box
WScript.Echo "Don't click me! Wait for event."

'  Event handler for the OnQuit event
Sub objIE_OnQuit()
    
    '  Show a message
    WScript.Echo "The user quit"
    
End Sub
