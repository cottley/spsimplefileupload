@echo off
rem
rem In order to link the sharepoint client into the exe using ilrepack, install the redistributable 
rem from the following url: http://www.microsoft.com/en-us/download/details.aspx?id=21786
rem

..\..\packages\ILRepack.1.22.2\tools\ilrepack /target:exe /out:spsfileupload.exe spsimplefileupload.exe CommandLine.dll "C:\Program Files\Common Files\Microsoft Shared\SharePoint Client\Microsoft.SharePoint.Client.dll" "C:\Program Files\Common Files\Microsoft Shared\SharePoint Client\Microsoft.SharePoint.Client.Runtime.dll"