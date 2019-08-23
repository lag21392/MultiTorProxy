@echo off
CD C:\MultiTor\
SETLOCAL
SETLOCAL ENABLEDELAYEDEXPANSION
set /a puerto=10000+%1

 SET /a sp=%puerto%+0
 SET /a pp=%puerto%+20000
 echo !sp!
 echo !cp!
 start /I /MIN bin\Polipo\polipo socksParentProxy="127.0.0.1:!sp!" proxyPort=!pp! proxyAddress="127.0.0.1"

ENDLOCAL