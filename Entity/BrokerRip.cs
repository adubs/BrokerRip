using Newtonsoft.Json;

namespace Entity
{
    public class BrokerRip
    {
        [JsonProperty("stockName")]
        public string StockName { get; set; }

        [JsonProperty("brokerName")]
        public string BrokerName { get; set; }

        [JsonProperty("targetIncrease")]
        public decimal TargetIncrease { get; set; }
    }
}