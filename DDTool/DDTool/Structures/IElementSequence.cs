using System;
using System.Collections.Generic;

namespace DDTool.Structures;

public interface IElementSequence {
    public string Name { get; }

    public Dictionary<int, IElement> Elements { get; }
    public HashSet<int> RequiredTags { get; }
    public List<int> TagOrder { get; }

    public List<DDField> RequiredFields { get; }

    public IEnumerable<DDGroup> Groups { get; }

    public void AddElement(IElement element, bool required);
}
