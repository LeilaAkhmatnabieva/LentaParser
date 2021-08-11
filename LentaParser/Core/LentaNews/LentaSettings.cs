using System;

namespace LentaNewsParser.Core.LentaNews
{
    class LentaSettings : IParserSettings
    {
        public LentaSettings(DateTime start, DateTime end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseURL { get; set; } = "https://lenta.ru/news";
        public string Prefix { get; set; } = "{CurrentId}";
        public DateTime StartPoint { get; set; }
        public DateTime EndPoint { get; set; }
    }
}
