@echo off
CD C:\MultiTor\
SETLOCAL
SETLOCAL ENABLEDELAYEDEXPANSION
set /a limitePuerto=10000+%1
FOR /L %%G IN (10001,1,%limitePuerto%) DO (
 SET /a sp=%%G+0
 SET /a pp=%%G+20000
 echo !sp!
 echo !cp!
 start bin\Polipo\polipo socksParentProxy="127.0.0.1:!sp!" proxyPort=!pp! proxyAddress="127.0.0.1"
)
ENDLOCAL