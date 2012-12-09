using System;
using Command_Line_Parser;

namespace APK_Statistics.Command_Line
{
    public class ApplicationCommandLine : CommandLine
    {
        public ApplicationCommandLine(string pathCommandLineConfigFile)
            : base(pathCommandLineConfigFile) { }

        public override void RunCommand(CalledCommand calledCommand)
        {
            switch (calledCommand.Name)
            {
                case "ext":
                    {
                        StatisticsCollector.ShowExtensionsStatistics();
                        break;
                    }
                case "test":
                    {
                        switch (calledCommand.MandatoryParametersValues[0])
                        {
                            case "manifest":
                                {
                                    Tester.TestManifest();
                                    break;
                                }
                        }
                        break;
                    }
                case "files":
                    {
                        StatisticsCollector.ShowFilesStatistics();
                        break;
                    }
                default:
                    {
                        FailCommand("Illegal command.");
                        break;
                    }
            }
        }
    }
}
