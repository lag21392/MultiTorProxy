@echo off
CD C:\MultiTor\
SETLOCAL
SETLOCAL ENABLEDELAYEDEXPANSION

set /a limitePuerto=10000+%1
FOR /L %%G IN (10001,1,%limitePuerto%) DO (
 SET /a sp=%%G+0
 SET /a cp=%%G+10000
 echo !sp!
 echo !cp!
 mkdir data\tor-!sp!
 start bin\Tor\tor.exe GeoIPFile bin\Data\Tor\geoip GeoIPv6File bin\Data\Tor\geoip6 SOCKSPort 127.0.0.1:!sp! CONTROLPort 127.0.0.1:!cp! DATADirectory data\tor-!sp!
)
ENDLOCAL