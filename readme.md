ServiceMatrix by Particular
===========================
ServiceMatrix is a product of the Particular Software Suite.

Get the logical view of your system from top-to-bottom knowing that your design is always in sync with your code.
Get an overview of:
* which components make up which services
* which contracts those services expose
* where messages are sent
* which events those messages cause
* which services are subscribed to those events

![ServiceMatrix Screenshoot](http://particular.net/Media/Default/Studio/ServiceMatrixScreen.png)


**Simple and powerful graphical design**
Get all the configuration files, initialization code, and references you need set up automatically. You can literally “F5 and go”.

All generated code is based on T4 templates allowing for easy customization. Make changes to your code knowing that your design will stay in sync.


**Useful Links:**

ServiceMatrix page: http://particular.net/ServiceMatrix-1
Download: http://particular.net/downloads
Licensing: http://particular.net/licensing


How To Build NServiceBus Studio
===============================

In order to build NServiceBus Studio, you will need the following dependencies installed based on the Visual Studio version that you want to create:


For Visual Studio 2012:

1. Visual Studio 2012 - Ultimate Edition
2. Visual studio 2012 SDK (http://www.microsoft.com/en-us/download/details.aspx?id=30668)
3. MS Visual Studio 2012 Visualization and Modeling Tools SDK (http://www.microsoft.com/en-us/download/details.aspx?id=30680)
4. NuPattern Toolkit Builder v.1.3.23.0 for VS2012 can be found at http://nupattern.codeplex.com/releases/view/107866

For Visual Studio 2013:

1. Visual Studio 2013 - Professional Edition
2. Microsoft Visual Studio 2013 SDK - http://www.microsoft.com/en-au/download/details.aspx?id=40758
3. Modeling SDK for Microsoft Visual Studio 2013 - http://www.microsoft.com/en-au/download/details.aspx?id=40754
4. NuPattern Toolkit Builder 1.4.24.0 - https://nupattern.codeplex.com/downloads/get/786828

After installing prerequisites, you can run AutomatedBuild\build.bat. That will build and generate NServiceBus Studio toolkit for both Visual Studio versions (VS2010 & VS2012.

On the Build Server 
========
The VS Build steps on TeamCity require command line params to set the path to the NuPattern components, there extension are named with a random file nam on disk so
this must be adjusted if teh build agent is changed/rebuilt or the user account changed.  The comamnd parameters look like 

/p:PatternToolkitRuntime=C:\Users\Administrator\APPDATA\LOCAL\MICROSOFT\VISUALSTUDIO\12.0\Extensions\f0g4nk5x.sh1;PatternToolkitBuilder=C:\USERS\ADMINISTRATOR\APPDATA\LOCAL\MICROSOFT\VISUALSTUDIO\12.0\EXTENSIONS\gkkzc4ak.stf

Signing of the VSIX also happens as part of build on Teamcity using an inhouse tool.  The tool expects the signing certificate to be disk, it does not us the certificate store (this will be fixed up later) 

First-Time Build
================

We've made some changes to the solution in order to avoid first-time build issues. However, be sure source code files are not blocked on Windows, and are not read-only.

Basic Troubleshooting
=====================

If you get an error saying the assembly NServiceBusStudio.Automation doesn't have a strong name, then you will need to manually add the snk file. Please go to the project properties for NServiceBusStudio.Automation, in the Signing tab you will need to check "Sign the assembly" and browse for NServiceBus.Tools.snk which is either in the same project folder or in the Studio/Solution Items folder. After that you should be able to build the solution successfully.

There might be some issues if there are read-only files that need to be generated during the build. To avoid those error be sure that the files are not read-only.
