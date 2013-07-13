using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Async
{
    public class AsyncScreenScraper
    {
        public async Task<string> GetUrlContentsAsync(string url)
        {

            using (var client = new HttpClient())
            {
                var pageString = await client.GetStringAsync(url);
                return pageString;
            }

        }
    }
}