using System.Collections.Generic;
using Entity;

namespace Logic.Async
{
    public class AggregatorResult
    {
        public List<BrokerRip> BrokerRips { get; set; }

        public int SourceCount { get; set; }
    }
}