@echo off
cd C:\Users\LAG\Desktop\MultiTor
bin\Tor\tor.exe GeoIPFile bin\Data\Tor\geoip GeoIPv6File bin\Data\Tor\geoip6 SOCKSPort 127.0.0.1:10001 CONTROLPort 127.0.0.1:20001 DATADirectory data\tor-10001