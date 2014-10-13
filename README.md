## WCF asynchronous duplex chat using net.tcp binding example

cloned from http://www.codeproject.com/Articles/596287/Broadcasting-Events-with-a-Duplex-WCF-Service
all credits and copyrights go there

manual:

- edit windows-binaries/runsvc.bat for your WcfSvcHost.exe path...
- execute
```
cd windows-binaries
runsvc.bat
BroadCastorClient.exe
```
- type "a" into Client Name
- click RegisterClient
- type "1" into Event Message
- click SendEvent
- see [1 (from a)] in the Messages...

[screen.png](screen.png)

Tested with Windows Server 2008 R2, Visual Studio 2013