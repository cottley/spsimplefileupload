spsimplefileupload
==================

A small utility that will upload a single document to a specified URL on a Sharepoint 2010 server.

The utility can be downloaded from the repo as [spsfileupload.exe](https://github.com/cottley/spsimplefileupload/blob/master/bin/Release/spsfileupload.exe)


 Sharepoint Simple File Upload 0.1.2.0
 Copyright (C) 2013 Christopher Ottley

 Example: spsfileupload -l"info.xlsx" -d"https://host.com/health/info.xlsx"

 Tries to upload info.xlsx to the sharepoint site URL.


  -l, --local    Required. Path to the local file that is to be uploaded.

  -d, --dest     Required. URL of the SharePoint site that the file is to be
                 uploaded to.

  --help         Display this help screen.
