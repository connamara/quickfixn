using System;
using System.Text;
using System.IO;

namespace TradeClient
{
    class Program
    {
        static void FixToJson(string fname, bool humanReadableValues, QuickFix.DataDictionary.DataDictionary sessionDataDictionary, QuickFix.DataDictionary.DataDictionary appDataDictionary)
        {
            try
            {
                Console.WriteLine("{\n\"messages\": [");
                using (StreamReader streamReader = new StreamReader(fname))
                {
                    QuickFix.IMessageFactory msgFactory = new QuickFix.DefaultMessageFactory();
                    QuickFix.Message msg = new QuickFix.Message();
                    string line = null;
                    string comma = "";
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        line = line.Trim();
                        msg.FromString(line, false, sessionDataDictionary, appDataDictionary, msgFactory);
                        Console.WriteLine(comma + msg.ToJSON(humanReadableValues));
                        comma = ",";
                    }
                }
                Console.WriteLine("]\n}");

            }
            catch (System.Exception e)
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
                System.Console.WriteLine("USAGE");
                System.Console.WriteLine("");
                System.Console.WriteLine("    FixToJson.exe FILE [HUMAN_READABLE_VALUES] [DATA_DICTIONARY]");
                System.Console.WriteLine("");
                System.Console.WriteLine("EXAMPLES");
                System.Console.WriteLine("");
                System.Console.WriteLine("    FixToJson.exe messages.log true ../../spec/fix/FIX50SP2.xml");
                System.Console.WriteLine("    FixToJson.exe messages.log true ../../spec/fix/FIX44.xml");
                System.Console.WriteLine("    FixToJson.exe messages.log false ../../spec/fix/FIX42.xml");
                System.Console.WriteLine("");
                System.Console.WriteLine("NOTE");
                System.Console.WriteLine("");
                System.Console.WriteLine("    Per the FIX JSON Encoding Specification, tags are converted to human-readable form, but values are not.");
                System.Console.WriteLine("    Set the HUMAN_READABLE_VALUES argument to TRUE to override the standard behavior.");
                System.Environment.Exit(2);
            }

            string fname = args[0];
            bool humanReadableValues = false;
            QuickFix.DataDictionary.DataDictionary sessionDataDictionary = null;
            QuickFix.DataDictionary.DataDictionary appDataDictionary = null;
 
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
