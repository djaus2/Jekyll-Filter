using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    class Program
    {
        //static FilterCls.filterMD.OutputMsg outMsg;

        //public static void Output (string msg)
        //{
        //    if (msg == "__CLEAR__")
        //        Console.WriteLine("");
        //    else
        //        Console.WriteLine(msg);
        //}
        static void Main(string[] args)
        {
            

            //outMsg = Output;

            FilterCls.filterMD.ExecFilters(args, null ,0);

            return;

            List<string> lineToStartAfter = new List<string>();
            bool started = true;
            List<string> linesToSkipStartingWith = new List<string>();
            List<string> linesToSkipContaining = new List<string>();
            List<string> lineToStopAt = new List<string>();

            if (args.Length==0)
            {
                Console.WriteLine("Usage: filter [LinesToSkip] [LinesContainingToStartAt] [LinesContainingToStopAt]");
                Console.WriteLine("[..] are optional args.");
                Console.WriteLine("The second arg requires the first arg to be present");
                Console.WriteLine("The third arg requires the first and second args to be present");
                Console.WriteLine("args are either single item or a comma separated list");
                Console.WriteLine("Single filter lists have @ as prefix");
                Console.WriteLine("If any spaces, arg should be in double quotes. (Whole arg not individual, comma sperated items.)");
                Console.WriteLine("LinesToSkip:              + or no prefix: Any line STARTING with one of these filters is skipped.");
                Console.WriteLine("                          + prefix is optional for lines starting with filters.");
                Console.WriteLine("                          Alternative is any filter with - prefix ");
                Console.WriteLine("                          - prefix: Any line CONTAINING that filter is skipped.");
                Console.WriteLine("LinesContainingToStartAt: Lines at start are skipped until first line after line containing one of these filters.");
                Console.WriteLine("LinesContainingToStopAt:  Lines at end are skipped from first line (that line inluded) containing one of these filters.");
                return;
            }
            if (args.Length > 0)
            {
                if (args[0].Length > 0)
                {
                    if (args[0][0] == '@')
                    {
                        // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                        linesToSkipStartingWith = new List<string> { args[0].Substring(1) };
                    }
                    linesToSkipStartingWith = (args[0].Split(new char[] { ',' })).ToList();
                }
            }

            linesToSkipContaining = (from f in linesToSkipStartingWith where f[0] == '-' select f).ToList();
            linesToSkipStartingWith = (from f in linesToSkipStartingWith where f[0] != '-' select f).ToList();
            for (int i = 0; i < linesToSkipStartingWith.Count(); i++)
                if (linesToSkipStartingWith[i][0] == '+')
                    linesToSkipStartingWith[i] = linesToSkipStartingWith[i].Substring(1);

            if (args.Length > 1)
            {
                if (args[1].Length > 0)
                {
                    if (args[1][0] == '@')
                    {
                        // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                        lineToStartAfter = new List<string> { args[1].Substring(1) };
                    }
                    lineToStartAfter = (args[1].Split(new char[] { ',' })).ToList();
                }
            }
            if (lineToStartAfter.Count() > 0)
                started = false;

            if (args.Length>2)
            {
                if (args[2].Length > 0)
                {
                    if (args[2][0] == '@')
                    {
                        // If string starts with @ then use whole argumenet as one (can therefore have a comma)
                        lineToStopAt = new List<string> { args[2].Substring(1) };
                    }
                    lineToStopAt = (args[2].Split(new char[] { ',' })).ToList();
                }
            }
                



            string line;
            while ((line = Console.ReadLine()) != null)
            {
                //Skip lines until
                if (!started)
                {
                    foreach (var f in lineToStartAfter)
                        if (line.Length >= f.Length)
                            if (line.Contains(f))
                            {
                                started = true;
                                break;
                            }
                    continue;
                }

                bool skip = false;
                //Lines to filter out starting with filter
                foreach (var f in linesToSkipStartingWith)
                    if (line.Length >= f.Length)
                        if (line.Substring(0, f.Length) == f)
                        {
                            skip=true;
                            break;
                        }
                if (skip)
                    continue;

                skip = false;
                //Lines to filter out containing filter
                foreach (var f in linesToSkipContaining)
                    if (line.Length >= f.Length)
                        if (line.Contains(f))
                        {
                            skip = true;
                            break;
                        }
                if (skip)
                    continue;

                bool stop = false;
                //Line to stop at
                foreach (var f in lineToStopAt)
                    if (line.Length >= f.Length)
                        if (line.Contains(f))
                        {
                            stop = true;
                            break;
                        }
                if (stop)
                    break;

                Console.WriteLine(line.ToUpper());
            }
        }
    }
}
