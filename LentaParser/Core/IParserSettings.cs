using System;

namespace LentaNewsParser.Core
{
    interface IParserSettings
    {
        string BaseURL { get; set; }
        string Prefix { get; set; }
        DateTime StartPoint { get; set; }
        DateTime EndPoint { get; set; }
    }
}
