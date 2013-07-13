using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;
using Logic.Async;

namespace Logic.BrokerSource
{
    public class ThisIsMoneyBrokerSource : IBrokerProvider
    {
        public async Task<List<BrokerRip>> PullSource()
        {
            var aScrape = new AsyncScreenScraper();
            var pageString = await aScrape.GetUrlContentsAsync("http://sharedealing.nandp.co.uk/broker-views/");

            var parser = new NandpParser();

            return parser.Parse(pageString);
        }
    }
}