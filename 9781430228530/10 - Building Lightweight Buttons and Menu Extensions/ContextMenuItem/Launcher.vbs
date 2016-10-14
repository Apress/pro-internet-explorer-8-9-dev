''  Grab the arguments passed to this script
Set Args = WScript.Arguments

''  Create a new Shell object
Set WshShell = WScript.CreateObject("WScript.Shell")

''  Concat all the passed arguments
Dim Command
For Each Arg in Args
   Command = Command + Chr(34) + Arg + Chr(34) + " "
Next

''  Send the concat string to the shell as a command
WshShell.Run Command, 1, False
