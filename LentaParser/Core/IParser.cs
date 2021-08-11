using AngleSharp.Html.Dom;

namespace LentaNewsParser.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
