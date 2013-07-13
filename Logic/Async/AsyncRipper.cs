using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Logic.Async
{
    public class AsyncRipper
    {
        public async Task<List<BrokerRip>> GetBrokerRips()
        {
            string str;
            var asyncScrape = new AsyncScreenScraper();

            str = await asyncScrape.GetUrlContentsAsync("blah.com");

            return new List<BrokerRip>();
        }
    }
}