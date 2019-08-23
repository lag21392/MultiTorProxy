@echo off
CD C:\MultiTor\
SETLOCAL
SETLOCAL ENABLEDELAYEDEXPANSION

set /a puerto=10000+%1

 SET /a sp=%puerto%+0
 SET /a cp=%puerto%+10000
 echo !sp!
 echo !cp!
 mkdir data\tor-!sp!
 start /I /MIN bin\Tor\tor.exe GeoIPFile bin\Data\Tor\geoip GeoIPv6File bin\Data\Tor\geoip6 SOCKSPort 127.0.0.1:!sp! CONTROLPort 127.0.0.1:!cp! DATADirectory data\tor-!sp!

ENDLOCAL