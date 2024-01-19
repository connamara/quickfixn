using System;
using System.Collections.Generic;
using DDTool.Structures;

namespace DDTool.Validations;

public static class FieldValidator {
    public static List<string> Check(DataDictionary dd) {
        var errors = new List<string>();
        foreach (var kvp in dd.FieldsByTag) {
            try {
                FieldTypeInfo.GetQfnFieldClass(kvp.Value);
            } catch (FieldTypeInfo.FieldTypeInfoException ex) {
                errors.Add($"Field {kvp.Key}/{kvp.Value.Name}: {ex.Message}");
            }
        }

        return errors;
    }
}
