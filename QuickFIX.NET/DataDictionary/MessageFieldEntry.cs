using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFIX.NET
{
    partial class DataDictionary
    {
        private sealed class MessageComponent
        {
            public enum TypeEnum { Field, Component, Group };

            public MessageComponent(string name, bool req, TypeEnum type )
            {
                Name = name;
                Required = req;
                SubComponents = new HashSet<MessageComponent>();
                ComponentType = type;
            }
            public TypeEnum ComponentType { get; set; }
            public string Name { get; set; }
            public bool Required { get; set; }
            public HashSet<MessageComponent> SubComponents { get; set; }

            public static TypeEnum GetComponentType(string typestr, string parentName)
            {
                TypeEnum ctype;
                switch (typestr)
                {
                    case "field": ctype = TypeEnum.Field; break;
                    case "group": ctype = TypeEnum.Group; break;
                    case "component": ctype = TypeEnum.Component; break;
                    default: throw new MessageParseException("unknown component in msg: " + parentName);
                }
                return ctype;
            }
        }
    }
}
