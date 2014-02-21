

@ECHO OFF
SET /P fname=Enter file to compile: 
IF "%fname%"=="" GOTO Error
cmd.exe /K C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\csc.exe %fname%
GOTO End
:Error
ECHO You did not enter a filename! Bye bye now!!
:End
