## Credits and Acknowledgments

LynxRAT is a heavily modified project of the Quasar RAT. We give full credit to MaxXor for creating the original Quasar RAT, which served as the foundation for LynxRAT. Without their incredible work, this project would not have been possible. Thank you, MaxXor, for your contribution to the community.

# LynxRAT

[![Build status](https://ci.appveyor.com/api/projects/status/5857hfy6r1ltb5f2?svg=true)](https://ci.appveyor.com/project/MaxXor/Quasar)
[![Downloads](https://img.shields.io/github/downloads/LynxRAT/LynxRAT/total.svg)](https://github.com/LynxRAT/LynxRAT/releases)
[![License](https://img.shields.io/github/license/Quasar/Quasar.svg)](LICENSE)

**Free, Open-Source Remote Administration Tool for Windows**

LynxRAT is a fast and light-weight remote administration tool coded in C#. The usage ranges from user support through day-to-day administrative work to employee monitoring. Providing high stability and an easy-to-use user interface, LynxRAT is the perfect remote administration solution for you.

Please check out the [Getting Started](https://github.com/Quasar/Quasar/wiki/Getting-Started) guide.


## TODO LIST

* ✅  Remote Chat
* ❌  Live keylogger
* ❌  Remote Webcam
* ❌  Live Microphone
  

## Screenshots

![remote-shell](Images/remote-shell.png)

![remote-desktop](Images/remote-desktop.png)

![remote-files](Images/remote-files.png)

## Features
* TCP network stream (IPv4 & IPv6 support)
* Fast network serialization (Protocol Buffers)
* Encrypted communication (TLS)
* UPnP Support (automatic port forwarding)
* Task Manager
* File Manager
* Startup Manager
* Remote Desktop
* Remote Shell
* Remote Execution
* System Information
* Registry Editor
* System Power Commands (Restart, Shutdown, Standby)
* Keylogger (Unicode Support)
* Reverse Proxy (SOCKS5)
* Password Recovery (Common Browsers and FTP Clients)
* ... and many more!

## Supported runtimes and operating systems
* .NET Framework 4.5.2 or higher
* Supported operating systems (32- and 64-bit)
  * Windows 11
  * Windows Server 2022
  * Windows 10
  * Windows Server 2019
  * Windows Server 2016
  * Windows 8/8.1
  * Windows Server 2012
  * Windows 7
  * Windows Server 2008 R2

## Compiling
Open the project `Quasar.sln` in Visual Studio 2019+ with installed .NET desktop development features and [restore the NuGET packages](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore). Once all packages are installed the project can be compiled as usual by clicking `Build` at the top or by pressing `F6`. The resulting executables can be found in the `Bin` directory. See below which build configuration to choose from.

## Documentation
See the [wiki](https://github.com/Quasar/Quasar/wiki) for usage instructions and other documentation.

## License
Quasar is distributed under the [MIT License](LICENSE).  
Third-party licenses are located [here](Licenses).

## Thank you!
I really appreciate all kinds of feedback and contributions. Thanks for using and supporting LynxRAT/Quasar!
