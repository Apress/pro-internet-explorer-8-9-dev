'  Declare a variable to hold an IE object
Dim objIE

'  Grab an IE automation object
Set objIE = WScript.CreateObject("InternetExplorer.Application")

'  Navigate to a webpage
objIE.Navigate "http://www.bing.com"

'  Set the browser as visible
objIE.Visible = 1

'  Wait for the page to load
Do
  Loop Until objIE.ReadyState = 4
    
'  Refer to the document object
Set objHtmlDocument = objIE.Document

'  Return the number of links on the page
WScript.Echo "There are " & objHtmlDocument.Links.Length & _
             " links on this page."
    


