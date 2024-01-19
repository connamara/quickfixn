using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace DDTool.Structures;

public class DDGroup : IElement, IElementSequence {
    public int Tag => CounterField.Tag;
    public string Name => CounterField.Name;

    public DDField CounterField { get; }

    public IElement Delimiter
    {
        get
        {
            if (TagOrder.Count < 1)
                throw new InvalidDataException($"Group {Name}/{Tag} has no elements");
            return Elements[TagOrder.First()];
        }
    }

    /// <summary>
    /// The first element is the delimiter
    /// </summary>
    public Dictionary<int, IElement> Elements { get; } = new();

    /// <summary>
    /// Includes delimiter
    /// </summary>
    public HashSet<int> RequiredTags { get; } = new();

    /// <summary>
    /// Includes delimiter (which is always first)
    /// </summary>
    public List<int> TagOrder { get; } = new();

    public List<DDField> RequiredFields => ElementSequenceImpl.RequiredFields(this);

    public IEnumerable<DDGroup> Groups => Elements.Values.OfType<DDGroup>();

    public DDGroup(DDField counter) {
        CounterField = counter;
    }

    public void AddElement(IElement element, bool required) {
        ElementSequenceImpl.AddElement(this, element, required);
    }
}
