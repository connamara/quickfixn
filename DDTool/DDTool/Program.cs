using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using DDTool.Parsers;
using DDTool.Structures;

namespace DDTool;

public static class Program {
    static void Main(string[] args) {
        var options = new Options(args);

        if (options.DDFiles.Count < 1) {
            Console.WriteLine("No input files.");
            Environment.Exit(1);
        }

        Console.WriteLine("Thank you for using the QuickFIX/n DDTool 9000.");
        Console.WriteLine("DD inputs:");
        foreach (var file in options.DDFiles)
            Console.WriteLine($"* {file}");

        if (!options.HasOutputDir) {
            Console.WriteLine("No output dir was specified, so I won't generate anything.");
        } else if (!Directory.Exists(options.OutputDir)) {
            Console.WriteLine($"OutputDir does not exist: {options.OutputDir}");
            Environment.Exit(1);
        } else {
            Console.WriteLine($"Generated files will be written to: {options.OutputDir}");
        }

        var errors = new List<string>();

        List<DataDictionary> dds = ParseDDs(options);
        foreach (DataDictionary dd in dds) {
            List<string> ddErrors = DDTool.Validations.FieldValidator.Check(dd);
            foreach (string dde in ddErrors)
                errors.Add($"{dd.SourceFile}: {dde}");
        }

        if (errors.Count > 0) {
            Console.WriteLine("============================");
            Console.WriteLine("Errors found.  Code generation (if commanded) will not run.");
            foreach (var err in errors)
                Console.WriteLine($"* {err}");
        }

        if (options.HasOutputDir) {
            List<DDField> aggFields = AggregateFields(dds);

            Console.WriteLine("============================");
            Console.WriteLine("Writing files:");

            Console.WriteLine($"* Wrote {Generators.GenFields.WriteFile(options.OutputDir, aggFields)}");
            Console.WriteLine($"* Wrote {Generators.GenFieldTags.WriteFile(options.OutputDir, aggFields)}");

            List<string> factory_files = Generators.GenMessageFactories.WriteFiles(options.OutputDir, dds);
            foreach (var ff in factory_files) {
                Console.WriteLine($"* Wrote {ff}");
            }

            // Messages
            foreach (var dd in dds.OrderBy(x => x.Identifier)) {
                var msgFiles = Generators.GenMessages.WriteFilesForDD(options.OutputDir, dd);
                Console.WriteLine($"* Wrote {msgFiles.Count} message files for {dd.IdentifierNoDots}");
                Console.WriteLine($"  From {msgFiles.First()}");
                Console.WriteLine($"    to {msgFiles.Last()}");
            }
        }
    }

    static List<DataDictionary> ParseDDs(Options options) {
        var dds = new List<DataDictionary>();
        foreach (var path in options.DDFiles) {
            try {
                var dd = DDParser.ParseFile(path);
                Console.WriteLine($"Parsed! -- {dd.Identifier}");
                dds.Add(dd);
            } catch (ApplicationException ex) {
                Console.WriteLine($"Error parsing {path}:");
                Console.WriteLine(ex.ToString());
                Environment.Exit(1);
            }
        }

        return dds;
    }

    /// <summary>
    /// Consolidate fields across all DDs into a single list
    /// </summary>
    /// <param name="dds"></param>
    /// <returns></returns>
    static List<DDField> AggregateFields(List<DataDictionary> dds) {
        // This impl is a little wierd, but it mirrors the weird Ruby design
        // and produces the same output.
        // Can probably write a cleaner version later.

        var rv = new List<DDField>();

        var fieldNames = new List<string>();
        foreach (var dd in dds.OrderBy(x => x.Identifier)) {
            foreach (var name in dd.FieldsByName.Keys) {
                if (!fieldNames.Contains(name))
                    fieldNames.Add(name);
            }
        }

        foreach (var name in fieldNames)
            rv.Add(MergedField(name, dds));

        return rv;
    }

    private static DDField MergedField(string name, List<DataDictionary> dds) {
        List<DDField> flds = new();

        foreach (var dd in dds.OrderByDescending(x => x.Identifier)) {
            if (dd.FieldsByName.TryGetValue(name, out DDField fld)) {
                flds.Add(fld);
            }
        }

        if (flds.Count < 1)
            throw new Exception($"couldn't find field: {name}"); // not likely

        DDField rv = flds.First(); // favor the latest Fix ver

        List<EnumValue> allEnumVals = new();
        foreach (var fld in flds) {
            foreach (var fldEnum in fld.Enums) {
                if (allEnumVals.All(ev => ev.Desc != fldEnum.Desc)) {
                    allEnumVals.Add(fldEnum);
                }
            }
        }

        rv.Enums = allEnumVals;
        return rv;
    }
}
