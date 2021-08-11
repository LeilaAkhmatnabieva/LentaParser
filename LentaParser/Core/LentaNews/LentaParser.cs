using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace LentaNewsParser.Core.LentaNews
{
    class LentaParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("h3").Where(item => item.ClassName != null && item.ClassName.Contains("card-title"));
            foreach (var item in items)
            {
                list.Add(item.TextContent);
            }
            return list.ToArray();
        }
    }
}

