using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickFix
{
    partial class DataDictionaryParser
    {
        private sealed class XMLMsgComponent
        {
            public enum TypeEnum { Field, Component, Group };

            public XMLMsgComponent(string name, bool req, TypeEnum type )
            {
                Name = name;
                Required = req;
                SubComponents = new List<XMLMsgComponent>();
                ComponentType = type;
            }
            public TypeEnum ComponentType { get; set; }
            public string Name { get; set; }
            public bool Required { get; set; }
            public List<XMLMsgComponent> SubComponents { get; set; }

            public static TypeEnum GetComponentType(string typestr, string parentName)
            {
                TypeEnum ctype;
                switch (typestr)
                {
                    case "field": ctype = TypeEnum.Field; break;
                    case "group": ctype = TypeEnum.Group; break;
                    case "component": ctype = TypeEnum.Component; break;
                    default: throw new MessageParseError("unknown component in msg: " + parentName);
                }
                return ctype;
            }
        }
    }
}
