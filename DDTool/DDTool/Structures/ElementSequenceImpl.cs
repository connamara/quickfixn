using System;
using System.Collections.Generic;
using DDTool.Exceptions;

namespace DDTool.Structures;

/* It was either this, or create an AbstractElementSequence class
     and further muddy up the class hierarchy.
   I'm still not sure which is less ugly.
   */
public static class ElementSequenceImpl {
    public static void AddElement(IElementSequence seq, IElement element, bool required) {
        if (seq.Elements.ContainsKey(element.Tag))
            throw new ParsingException($"Tag {element.Tag} appears twice in {seq.Name}");

        seq.Elements[element.Tag] = element;
        seq.TagOrder.Add(element.Tag);
        if (required)
            seq.RequiredTags.Add(element.Tag);
    }

    public static List<DDField> RequiredFields(IElementSequence seq) {
        List<DDField> rv = new List<DDField>();
        foreach (var reqTag in seq.RequiredTags) {
            var el = seq.Elements[reqTag];
            if (el is DDField field)
                rv.Add(field);
        }

        return rv;
    }
}
