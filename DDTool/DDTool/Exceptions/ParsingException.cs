using System;

namespace DDTool.Exceptions;

public class ParsingException : ApplicationException
{
    public ParsingException() { }

    public ParsingException(string msg)
        : base(msg)
    { }
}
