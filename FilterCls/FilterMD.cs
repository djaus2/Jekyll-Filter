using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterCls
{
    

    public  static class filterMD
    {
        public delegate void OutputMsg(string msg);
        private static bool UseConsole = false;
        private static bool UseLines = false;
        private static int LinesIndex = 0;
        private static string[] Lines = null;

        public static void OutputX(string msg)
        {
            if (msg == "__CLEAR__")
                Console.WriteLine("");
            else
                Console.WriteLine(msg);
        }



        public static void ExecFilters(string[] args, OutputMsg output, int noLinesToSkipAtStart, string[] lines = null)
        {
            UseConsole = false;
            UseLines = false;
            int argsCount = 0;
            StreamReader sr = null;

            OutputMsg Output = null;
            if (output == null)
            {
                UseConsole = true;
                Output = OutputX;
            }
            else
                Output = output;

            if (!UseConsole)
            {
                if (lines != null)
                {
                    UseLines = true;
                    Lines = lines;
                    LinesIndex = 0;
                }
                else
                {
                    //Last parameter is source file path
                    string SrcFilePath = "";
                    if (args.Count() < 1)
                    {
                        Output("No source file");
                        return;
                    }
                    else
                    {
                        SrcFilePath = args[args.Count() - 1];
                        argsCount = 1;
                        sr = null;
                        if (File.Exists(SrcFilePath))// only executes if the file at pathtofile exists//you need to add the using System.IO reference at the top of te code to use this
                        {
                            if (SrcFilePath != "")
                            {
                                sr = File.OpenText(SrcFilePath);
                            }
                        }
                        if (sr == null)
                        {
                            Output("File not found)");
                            return;
                        }
                    }
                }
            }
        
            
            string lineToStartAfter = "";
            bool started = true;
            List<string> linesToSkipStartingWith = new List<string>();
            List<string> linesToSkipContaining = new List<string>();
            string lineToStopAt = "";

            
                

            int NoLinesToSkipAtStart = noLinesToSkipAtStart;

            Output("__CLEAR__");
            if (args.Length ==0)
            {
                Output("Usage: filter [LinesToSkip] [LinesContainingToStartAt] [LinesContainingToStopAt]");
                Output("[..] are optional args.");
                Output("The second arg requires the first arg to be present");
                Output("The third arg requires the first and second args to be present");
                Output("args are either single item or a comma separated list");
                Output("Single filter lists have @ as prefix");
                Output("If any spaces, arg should be in double quotes. (Whole arg not individual, comma sperated items.)");
                Output("LinesToSkip:              + or no prefix: Any line STARTING with one of these filters is skipped.");
                Output("                          + prefix is optional for lines starting with filters.");
                Output("                          Alternative is any filter with - prefix ");
                Output("                          - prefix: Any line CONTAINING that filter is skipped.");
                Output("LinesContainingToStartAt: Lines at start are skipped until first line after line containing one of these filters.");
                Output("LinesContainingToStopAt:  Lines at end are skipped from first line (that line inluded) containing one of these filters.");
                return;
            }

            else if (args[1].ToLower() == "help")
            {
                Output("Usage: filter [LinesToSkip] [LinesContainingToStartAt] [LinesContainingToStopAt]");
                Output("[..] are optional args.");
                Output("The second arg requires the first arg to be present");
                Output("The third arg requires the first and second args to be present");
                Output("args are either single item or a comma separated list");
                Output("Single filter lists have @ as prefix");
                Output("If any spaces, arg should be in double quotes. (Whole arg not individual, comma sperated items.)");
                Output("LinesToSkip:              + or no prefix: Any line STARTING with one of these filters is skipped.");
                Output("                          + prefix is optional for lines starting with filters.");
                Output("                          Alternative is any filter with - prefix ");
                Output("                          - prefix: Any line CONTAINING that filter is skipped.");
                Output("LinesContainingToStartAt: Lines at start are skipped until first line after line containing one of these filters.");
                Output("LinesContainingToStopAt:  Lines at end are skipped from first line (that line inluded) containing one of these filters.");
                return;
            }
            if (args.Length > argsCount++)
            {
                if (args[0].Length > 0)
                {
                    if (args[0][0] == '@')
                    {
                        // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                        linesToSkipStartingWith = new List<string> { args[0].Substring(1) };
                    }
                    else
                        linesToSkipStartingWith = (args[0].Split(new string[] { "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                }
            }

            //Skip lines:
            //Starting with is default. + prefix = starting with  - prefix is contains
            linesToSkipContaining = (from f in linesToSkipStartingWith where f[0] == '-' select f).ToList();
            linesToSkipStartingWith = (from f in linesToSkipStartingWith where f[0] != '-' select f).ToList();
            for (int i = 0; i < linesToSkipStartingWith.Count(); i++)
                if (linesToSkipStartingWith[i][0] == '+')
                    linesToSkipStartingWith[i] = linesToSkipStartingWith[i].Substring(1);

            if (args.Length > argsCount++)
            {
                if (args[1].Length > 0)
                {
                    // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                    lineToStartAfter = args[1];
                }
            }
            if (lineToStartAfter.Count() > 0)
                started = false;

            if (args.Length > argsCount++)
            {
                if (args[2].Length > 0)
                {
                    lineToStopAt = args[2];
                }
            }


            int skipstart = NoLinesToSkipAtStart;
            bool stop = false;

                   
            string line;
            while (((line = ReadLine(sr)) != null) && (!stop))
            {
                if (skipstart-- > 0)
                {
                    Output(line);
                    continue;
                }

                //Skip lines until
                //Doesn't include start line
                if (!started)
                {
                    if(line.ToLower().Contains(lineToStartAfter.ToLower()))
                        started = true;
                    continue;
                }

                bool skip = false;
                //Lines to filter out starting with filter
                foreach (var f in linesToSkipStartingWith)
                    if (line.Length >= f.Length)
                        if (line.ToLower().Substring(0, f.Length) == f.ToLower())
                        {
                            skip = true;
                            break;
                        }
                if (skip)
                    continue;

                skip = false;
                //Lines to filter out containing filter
                foreach (var f in linesToSkipContaining)
                    if (line.Length >= f.Length)
                        if (line.ToLower().Contains(f.ToLower()))
                        {
                            skip = true;
                            break;
                        }
                if (skip)
                    continue;


                //Doesn't include stop line
                if (line.ToLower().Contains(lineToStopAt.ToLower()))
                {
                    stop = true;
                    break; 
                }
                Output(line);
            }
            



        }

        
        private static string ReadLine (StreamReader sr)
        {
            if (sr != null)
                return sr.ReadLine();
            else if (UseLines)
            {
                if (LinesIndex >= Lines.Count())
                    return null;
                else
                    return (Lines[LinesIndex++]);
            }
            else if (UseConsole)
                return Console.ReadLine();
            else
                return null;
        }
    }
}
