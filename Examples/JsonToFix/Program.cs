using System;
using System.IO;
using System.Text.Json;
using QuickFix;

namespace Examples.JsonToFix
{
    internal static class Program
    {
        static void JsonMsgToFix(string json, QuickFix.DataDictionary.DataDictionary sessionDataDictionary, QuickFix.DataDictionary.DataDictionary appDataDictionary, QuickFix.IMessageFactory msgFactory)
        {
            var msg = new Message();
            msg.FromJson(json, true, sessionDataDictionary, appDataDictionary, msgFactory);
            Console.WriteLine(msg.ConstructString());
        }

        static void JsonToFix(string fname, QuickFix.DataDictionary.DataDictionary sessionDataDictionary, QuickFix.DataDictionary.DataDictionary appDataDictionary)
        {
            try
            {
                QuickFix.IMessageFactory msgFactory = new QuickFix.DefaultMessageFactory();
                string json = File.ReadAllText(fname);
                using (JsonDocument document = JsonDocument.Parse(json))
                {
                    if (document.RootElement.TryGetProperty("messages", out JsonElement messagesElement))
                    {
                        foreach (JsonElement jsonMsg in messagesElement.EnumerateArray())
                        {
                            JsonMsgToFix(jsonMsg.ToString(), sessionDataDictionary, appDataDictionary, msgFactory);
                        }
                    }
                    else // assume there is only one message instead of an array of messages
                    {
                        JsonMsgToFix(json, sessionDataDictionary, appDataDictionary, msgFactory);
                    }
                }
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
            if (args.Length < 1 || args.Length > 2)
            {
                Console.WriteLine("USAGE");
                Console.WriteLine("");
                Console.WriteLine("    FixToJson.exe FILE DATA_DICTIONARY");
                Console.WriteLine("");
                Console.WriteLine("    The FILE may contain either a single message in FIX JSON Encoding, or an array of messages in a root-level \"messages\" element.");
                Console.WriteLine("");
                Console.WriteLine("EXAMPLES");
                Console.WriteLine("");
                Console.WriteLine("    JsonToFix.exe messages.json  ../../spec/fix/FIX50SP2.xml");
                Console.WriteLine("    JsonToFix.exe messages.json ../../spec/fix/FIX44.xml");
                Console.WriteLine("    JsonToFix.exe messages.json ../../spec/fix/FIX42.xml");
                Console.WriteLine("");
                Console.WriteLine("NOTE");
                Console.WriteLine("");
                Console.WriteLine("    Per the FIX JSON Encoding Specification, tags are converted to human-readable form, but values are not.");
                Environment.Exit(2);
            }

            string fname = args[0];
            QuickFix.DataDictionary.DataDictionary sessionDataDictionary = new QuickFix.DataDictionary.DataDictionary(args[1]);
            QuickFix.DataDictionary.DataDictionary appDataDictionary = sessionDataDictionary;

            JsonToFix(fname, sessionDataDictionary, appDataDictionary);
            Environment.Exit(1);
        }
    }
}
