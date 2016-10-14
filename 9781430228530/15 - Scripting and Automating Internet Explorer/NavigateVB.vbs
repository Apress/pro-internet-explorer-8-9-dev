'  Declare a variable to hold an IE object
Dim objIE

'  Grab an IE automation object
Set objIE = WScript.CreateObject("InternetExplorer.Application")

'  Navigate to a webpage
objIE.Navigate "http://www.bing.com"

'  Set the browser as visible
objIE.Visible = 1