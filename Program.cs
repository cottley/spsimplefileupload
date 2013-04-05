#region License
// <copyright file="Program.cs" company="Your name here">
//   Copyright 2013 Your name here
// </copyright>
//
// [License Body Here]
#endregion

namespace spsimplefileupload
{
    #region Using Directives
    using System;
    using CommandLine;
    using CommandLine.Text;
    using System.Collections.Generic;
    using Microsoft.SharePoint; // http://www.microsoft.com/en-us/download/details.aspx?id=21786
    using Microsoft.SharePoint.Client; // http://www.microsoft.com/en-us/download/details.aspx?id=21786
    using System.IO;
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();

            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                Environment.Exit(CommandLine.Parser.DefaultExitCodeFail);
            }

            try
            {

                Console.WriteLine(Environment.NewLine + " " + ThisAssembly.Title + " " + ThisAssembly.Version);
                Console.WriteLine(ThisAssembly.Copyright + Environment.NewLine);

                Uri fileUrl = new Uri(options.SharepointURL);

                if (fileUrl.Scheme.Equals("http") || fileUrl.Scheme.Equals("https"))
                {
                    /*
                     * Based on concept from http://blogs.msdn.com/b/sridhara/archive/2010/03/12/uploading-files-using-client-object-model-in-sharepoint-2010.aspx
                     */
                    String sharepointServer = fileUrl.GetComponents(UriComponents.SchemeAndServer, UriFormat.UriEscaped);

                    ClientContext context = new ClientContext(sharepointServer);

                    String destpath = fileUrl.GetComponents(UriComponents.Path, UriFormat.UriEscaped);

                    using (FileStream fs = new FileStream(options.LocalPath, FileMode.Open))
                    {

                        Microsoft.SharePoint.Client.File.SaveBinaryDirect(context, "/" + destpath, fs, true);

                    }

                    Console.WriteLine(" Upload successfull!");
                }
                else
                {
                    Console.WriteLine(" Error! Could not connect to Sharepoint server.\n Only http and https urls supported.");
                    Environment.Exit(-2);
                }
            }
            catch (System.Net.WebException webex)
            {
                Console.WriteLine(" Error! Could not connect to Sharepoint server. Please check your connection.");
                Console.WriteLine(" " + webex.Message);
                Environment.Exit(-3);
            }
            catch (System.UriFormatException ufe)
            {
                Console.WriteLine(" Error! Could not connect to Sharepoint server. Invalid URI.");
                Console.WriteLine(" " + ufe.Message);
                Environment.Exit(-4);
            }
            catch (System.IO.FileNotFoundException fnfe)
            {
                Console.WriteLine(" Error! Could not read file for upload.");
                Console.WriteLine(" " + fnfe.Message);
                Environment.Exit(-5);
            }
        }
    }
}
