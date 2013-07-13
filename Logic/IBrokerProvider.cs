using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;

namespace Logic
{
    public interface IBrokerProvider
    {
        Task<List<BrokerRip>> PullSource();
    }
}