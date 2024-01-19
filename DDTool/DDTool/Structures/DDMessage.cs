using System;
using System.Collections.Generic;
using System.Linq;

namespace DDTool.Structures;

public class DDMessage : IElementSequence {
    public string Name { get; }
    public string MsgType { get; private set; }
    public string Cat { get; private set; }

    public Dictionary<int, IElement> Elements { get; } = new();
    public HashSet<int> RequiredTags { get; } = new();
    public List<int> TagOrder { get; } = new();

    public List<DDField> RequiredFields => ElementSequenceImpl.RequiredFields(this);

    public IEnumerable<DDGroup> Groups => Elements.Values.OfType<DDGroup>();

    public DDMessage(string name, string msgType, string msgCat) {
        Name = name;
        MsgType = msgType;
        Cat = msgCat;
    }

    public void AddElement(IElement element, bool required) {
        ElementSequenceImpl.AddElement(this, element, required);
    }

}
