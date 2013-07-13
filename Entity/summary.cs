using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entity
{
    public class summary
    {
        [JsonProperty("brokerRips")]
        public List<BrokerRip> BrokerRips { get; set; }

        [JsonProperty("sourceCount")]
        public int SourceCount { get; set; }
    }
}