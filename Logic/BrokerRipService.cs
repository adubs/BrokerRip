using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Logic.Async;

namespace Logic
{
    public class BrokerRipService : IBrokerRipService
    {
        private readonly ISourceAggregator _sourceAggregator;

        public BrokerRipService(ISourceAggregator sourceAggregator)
        {
            _sourceAggregator = sourceAggregator;
        }

        public async Task<summary> GetBrokerSummary(decimal targetIncreasePercentage)
        {
            var aggregatorResult =await _sourceAggregator.PullSources();

            var summary = new summary
                {
                    BrokerRips =
                        aggregatorResult.BrokerRips.Where(br => br.TargetIncrease >= targetIncreasePercentage).ToList(),
                    SourceCount = aggregatorResult.SourceCount
                };

            return summary;
        }
    }

    public interface IBrokerRipService
    {
        Task<summary> GetBrokerSummary(decimal targetIncreasePercentage);
    }
}