using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LentaNewsParser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseURL}/{settings.Prefix}";

        }
        public async Task<string> GetSourseByPageId(DateTime date)
        {
            var currentUrl = url.Replace("{CurrentId}", $"{date.Year}/0{date.Month}/0{date.Day}/");
            var response = await client.GetAsync(currentUrl);

            string sourse = null;
            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }
            return sourse;
        }

    }
}
