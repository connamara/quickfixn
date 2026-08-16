using System;
using System.Collections.Generic;
using System.Linq;
using DDTool.Structures;

namespace DDTool.Validations;

public static class BrokerProjectValidator {
    /// <summary>
    /// With --brokerproject, every DD must declare a unique customname on the root &lt;fix&gt; tag.
    /// </summary>
    public static List<string> Check(IReadOnlyList<DataDictionary> dds) {
        var errors = new List<string>();

        foreach (var dd in dds) {
            if (string.IsNullOrWhiteSpace(dd.CustomName)) {
                errors.Add($"{dd.SourceFile}: --brokerproject requires a \"customname\" attribute "
                           + $"on the root <fix> tag (got none; would fall back to \"{dd.IdentifierNoDots}\").");
            }
        }

        var named = dds.Where(dd => !string.IsNullOrWhiteSpace(dd.CustomName)).ToList();
        var duplicates = named
            .GroupBy(dd => dd.CustomName!, StringComparer.Ordinal)
            .Where(g => g.Count() > 1)
            .ToList();

        foreach (var group in duplicates) {
            string files = string.Join(", ", group.Select(dd => dd.SourceFile));
            errors.Add($"Duplicate customname \"{group.Key}\" in --brokerproject input set.  "
                       + $"Each dictionary must have a unique customname.  Files: [{files}]");
        }

        return errors;
    }
}
