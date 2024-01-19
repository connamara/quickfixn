using System;
using System.Collections.Generic;
using System.Linq;

namespace DDTool;

public class Options {
    public string OutputDir { get; }

    public bool HasOutputDir => !string.IsNullOrEmpty(OutputDir);

    public List<string> DDFiles { get; } = new List<string>();

    public Options(string[] args) {
        var errors = new List<string>();

        var argList = new LinkedList<string>(args);
        while (argList.Count > 0) {
            var next = argList.First();
            argList.RemoveFirst();

            if (next.Contains('=')) {
                var splist = next.Split("=");
                next = splist[0];
                argList.AddFirst(splist[1]);
            }

            switch (next) {
                case "--outputdir":
                    OutputDir = argList.First();
                    argList.RemoveFirst();
                    break;

                default:
                    if (next.StartsWith("-"))
                        errors.Add($"Unrecognized option: {next}");
                    else {
                        // All done with cmd line options now,
                        //   the rest are files.
                        DDFiles.Add(next);
                        foreach (var arg in argList) {
                            if (!arg.EndsWith(".xml"))
                                throw new Exception($"This isn't an xml file: {arg}");
                            DDFiles.Add(arg);
                        }

                        argList.Clear(); // to break the loop
                    }

                    break;
            }
        }

        if (errors.Count > 0) {
            Console.WriteLine("Parameter errors:");
            foreach (var err in errors)
                Console.WriteLine($"* {err}");
            Environment.Exit(1);
        }
    }
}
