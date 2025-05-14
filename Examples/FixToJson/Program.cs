using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Examples.FixToJson
{
    internal static class Program
    {
        static void FixToJson(
            string fname,
            bool humanReadableValues,
            QuickFix.DataDictionary.DataDictionary? sessionDataDictionary,
            QuickFix.DataDictionary.DataDictionary? appDataDictionary,
            List<int>? tagsToMask,
            string? maskText)
        {
            try
            {
                Console.WriteLine("{\n\"messages\": [");
                using (StreamReader streamReader = new StreamReader(fname))
                {
                    QuickFix.IMessageFactory msgFactory = new QuickFix.DefaultMessageFactory();
                    QuickFix.Message msg = new QuickFix.Message();
                    string comma = "";
                    while (streamReader.ReadLine() is { } line)
                    {
                        line = line.Trim();
                        msg.FromString(line, false, sessionDataDictionary, appDataDictionary, msgFactory);
                        if(maskText is not null) {
                            Console.WriteLine(comma + msg.ToJSON(appDataDictionary, convertEnumsToDescriptions: humanReadableValues, tagsToMask, maskText));
                        }
                        else {
                            Console.WriteLine(comma + msg.ToJSON(appDataDictionary, convertEnumsToDescriptions: humanReadableValues, tagsToMask));
                        }
                        comma = ",";
                    }
                }
                Console.WriteLine("]\n}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("USAGE");
                Console.WriteLine("");
                Console.WriteLine("    FixToJson.exe FILE [-h | --human-readable] [-d <data_dictionary_path>] [-m | --mask <tags_to_mask>] [--mask-text <mask_text>]");
                Console.WriteLine("");
                Console.WriteLine("EXAMPLES");
                Console.WriteLine("");
                Console.WriteLine("    FixToJson.exe messages.log -h -d ../../spec/fix/FIX50SP2.xml");
                Console.WriteLine("    FixToJson.exe messages.log -h -d ../../spec/fix/FIX44.xml -m 52,448,560 --masktext [MASK]");
                Console.WriteLine("    FixToJson.exe messages.log -d ../../spec/fix/FIX42.xml");
                Console.WriteLine("    FixToJson.exe messages.log -m 15,236,448");
                Console.WriteLine("");
                Console.WriteLine("NOTE");
                Console.WriteLine("");
                Console.WriteLine("    Per the FIX JSON Encoding Specification, tags are converted to human-readable form, but values are not.");
                Console.WriteLine("    Set the -h or --human-readable flag to override the standard behavior. If the --human-readable flag is set a data dictionary must also be provided.");
                Console.WriteLine("    If desired use the -m or --mask flag followed by a comma delimited list of tags that should be masked in the FIX JSON output.");
                Console.WriteLine("    To specify custom text for the mask use the --mask-text flag followed by the text to use for masking.");
                Environment.Exit(2);
            }

            string fname = args[0];
            bool humanReadableValues = false;
            QuickFix.DataDictionary.DataDictionary? sessionDataDictionary = null;
            QuickFix.DataDictionary.DataDictionary? appDataDictionary = null;
            List<int>? tagsToMask = null;
            string? maskText = null;

            for (int i = 1; i < args.Length; i++)
            {
                switch(args[i].ToLower())
                {
                    case "-h":
                    case "--human-readable":
                        humanReadableValues = true;
                        break;
                    case "-d":
                        sessionDataDictionary = new QuickFix.DataDictionary.DataDictionary(args[++i]);
                        appDataDictionary = sessionDataDictionary;
                        break;
                    case "-m":
                    case "--mask":
                        tagsToMask = args[++i].Split(',').Select(int.Parse).ToList();
                        break;
                    case "--mask-text":
                        maskText = args[++i];
                        break;
                    default:
                        Console.WriteLine($"Unknown argument: {args[i]}");
                        Environment.Exit(2);
                        break;
                }
            }
            
            FixToJson(fname, humanReadableValues, sessionDataDictionary, appDataDictionary, tagsToMask, maskText);
            Environment.Exit(1);
        }
    }
}
