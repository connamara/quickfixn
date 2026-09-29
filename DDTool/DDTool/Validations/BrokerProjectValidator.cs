using System;
using System.Collections.Generic;
using System.Linq;
using DDTool.Structures;

namespace DDTool.Validations;

public static class BrokerProjectValidator {
    /// <summary>
    /// Check that all broker DDs have customnames that are
    /// (1) present (specified as "customname" attribute on root &lt;fix&gt; tag)
    /// (2) unique (no two DDs may have the same customname)
    /// </summary>
    public static List<string> Check(IReadOnlyList<DataDictionary> dds) {
        List<string> errors = [];

        foreach (DataDictionary dd in dds) {
            if (string.IsNullOrWhiteSpace(dd.CustomName)) {
                errors.Add($"{dd.SourceFile}: --brokerproject requires a \"customname\" attribute "
                           + $"on the root <fix> tag");
            }
        }

        List<DataDictionary> named = dds.Where(dd => !string.IsNullOrWhiteSpace(dd.CustomName)).ToList();
        List<IGrouping<string,DataDictionary>> duplicates = named
            .GroupBy(dd => dd.CustomName!, StringComparer.Ordinal)
            .Where(g => g.Count() > 1)
            .ToList();

        foreach (IGrouping<string,DataDictionary> group in duplicates) {
            string files = string.Join(", ", group.Select(dd => dd.SourceFile));
            errors.Add($"Duplicate customname \"{group.Key}\" in --brokerproject input set.  "
                       + $"Each dictionary must have a unique customname.  Files: [{files}]");
        }

        return errors;
    }
}
