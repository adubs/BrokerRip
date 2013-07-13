using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;

namespace Logic.Async
{
    public class SourceAggregator : ISourceAggregator
    {
        private readonly List<IBrokerProvider> _brokerSources;

        public SourceAggregator(List<IBrokerProvider> brokerSources)
        {
            _brokerSources = brokerSources;
        }

        public async Task<AggregatorResult> PullSources()
        {
            IEnumerable<Task<List<BrokerRip>>> brokerSourceTasks =
            from brokerSource in _brokerSources select brokerSource.PullSource();

            Task<List<BrokerRip>>[] brokerTasksArr = brokerSourceTasks.ToArray();
            List<BrokerRip>[] allSourceResults = await Task.WhenAll(brokerTasksArr);

            var allSourceArr = allSourceResults;

            var allSources = new List<BrokerRip>();

            foreach (var brokerRips in allSourceArr)
            {
                allSources.AddRange(brokerRips);
            }

            return new AggregatorResult{BrokerRips = allSources, SourceCount = _brokerSources.Count};
        }
    }
}