// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX44;

public class XMLnonFIX : Message
{
    public const string MsgType = "n";

    public XMLnonFIX() : base()
    {
        Header.SetField(new MsgType("n"));
    }
}
