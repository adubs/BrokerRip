using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Logic.Async
{
    public interface ISourceAggregator
    {
        Task<AggregatorResult> PullSources();
    }
}