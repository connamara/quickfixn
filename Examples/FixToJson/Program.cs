using System;
using System.IO;

namespace Examples.FixToJson
{
    internal static class Program
    {
        static void FixToJson(
            string fname,
            bool humanReadableValues,
            QuickFix.DataDictionary.DataDictionary? sessionDataDictionary,
            QuickFix.DataDictionary.DataDictionary? appDataDictionary)
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
                        Console.WriteLine(comma + msg.ToJSON(convertEnumsToDescriptions: humanReadableValues));
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
            if (args.Length < 1 || args.Length > 4)
            {
                Console.WriteLine("USAGE");
                Console.WriteLine("");
                Console.WriteLine("    FixToJson.exe FILE [HUMAN_READABLE_VALUES] [DATA_DICTIONARY]");
                Console.WriteLine("");
                Console.WriteLine("EXAMPLES");
                Console.WriteLine("");
                Console.WriteLine("    FixToJson.exe messages.log true ../../spec/fix/FIX50SP2.xml");
                Console.WriteLine("    FixToJson.exe messages.log true ../../spec/fix/FIX44.xml");
                Console.WriteLine("    FixToJson.exe messages.log false ../../spec/fix/FIX42.xml");
                Console.WriteLine("");
                Console.WriteLine("NOTE");
                Console.WriteLine("");
                Console.WriteLine("    Per the FIX JSON Encoding Specification, tags are converted to human-readable form, but values are not.");
                Console.WriteLine("    Set the HUMAN_READABLE_VALUES argument to TRUE to override the standard behavior.");
                Environment.Exit(2);
            }

            string fname = args[0];
            bool humanReadableValues = false;
            QuickFix.DataDictionary.DataDictionary? sessionDataDictionary = null;
            QuickFix.DataDictionary.DataDictionary? appDataDictionary = null;
 
            if (args.Length > 1)
            {
                humanReadableValues = bool.Parse(args[1]);
            }

            if (args.Length > 2)
            {
                sessionDataDictionary = new QuickFix.DataDictionary.DataDictionary(args[2]);
                appDataDictionary = sessionDataDictionary;
            }
            
            FixToJson(fname, humanReadableValues, sessionDataDictionary, appDataDictionary);
            Environment.Exit(1);
        }
    }
}
