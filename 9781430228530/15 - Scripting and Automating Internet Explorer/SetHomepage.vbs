'  Store values or this script
HKEY_CURRENT_USER = &H80000001
strComputer = "."
strKeyPath = "SOFTWARE\Microsoft\Internet Explorer\Main"
strValue = "Start Page"
strData = "http://www.microsoft.com"

'  Get the registry provider for the local machine from WMI
Set objReg = GetObject("winmgmts:\\" & strComputer & _
             "\root\default:StdRegProv")
             
'  Ensure the target key exists (fails gracefully)
objReg.CreateKey HKEY_CURRENT_USER, strKeyPath

'  Set the value and data to the target key
objReg.SetStringValue HKEY_CURRENT_USER, strKeyPath, _
   strValue, strData
