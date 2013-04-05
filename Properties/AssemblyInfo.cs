#region License
// <copyright file="Assembly.cs" company="Your name here">
//   Copyright 2013 Your name here
// </copyright>
//
// [License Body Here]
#endregion
#region Using Directives
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using CommandLine;
#endregion

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle(ThisAssembly.Title)]
[assembly: AssemblyDescription("Attempt to upload a single file to the specified Sharepoint URL")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright(ThisAssembly.Copyright)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion(ThisAssembly.Version)]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]

[assembly: CommandLine.AssemblyUsage(
  "\n Example: spsfileupload -l\"info.xlsx\" -d\"https://host.com/health/info.xlsx\"",
  "\n Tries to upload info.xlsx to the sharepoint site URL.\n")]