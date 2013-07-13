using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;
using HtmlAgilityPack;

namespace Logic.BrokerSource
{
    public class ThisIsMoneyParser
    {
        public List<BrokerRip> Parse(string pageString)
        {
            var doc = new HtmlDocument();
            doc.LoadHtml(pageString);
            var brokerRips = new List<BrokerRip>();
            decimal increase;

            var tab = doc.DocumentNode.SelectNodes("/html/body/div/div[3]/div/div[3]/table/tbody/tr");

            foreach (HtmlNode row in tab)
            {
                var cols = row.SelectNodes("td");
                try
                {
                    var currentPrice = decimal.Parse(cols[5].InnerText);
                    var targetPrice = decimal.Parse(cols[8].InnerText);
                    increase = CalcIncrease(currentPrice, targetPrice);
                }
                catch (Exception e)
                {
                    increase = 0;
                    Console.WriteLine(e);
                }

                brokerRips.Add(new BrokerRip
                    {
                        StockName = cols[1].InnerText,
                        BrokerName = cols[3].InnerText,
                        TargetIncrease = increase
                    });
            }

            return brokerRips;
        }

        private static decimal CalcIncrease(decimal currentPrice, decimal targetPrice)
        {
            return Math.Round((targetPrice - currentPrice)/currentPrice*100);
        }
    }
}