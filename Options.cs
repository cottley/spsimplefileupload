#region License
// <copyright file="Options.cs" company="Your name here">
//   Copyright 2013 Your name here
// </copyright>
//
// [License Body Here]
#endregion

namespace spsimplefileupload
{
    #region Using Directives
    using CommandLine;
    using CommandLine.Text;
    #endregion

    internal class Options
    {
        [Option('l', "local", Required = true, HelpText = "Path to the local file that is to be uploaded.")]
        public string LocalPath { get; set; }

        [Option('d', "dest", Required = true, HelpText = "URL of the SharePoint site that the file is to be uploaded to.")]
        public string SharepointURL { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            string result = System.Environment.NewLine + " " + HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
            return result;
        }
    }
}
