using System.Threading.Tasks;
using System.Web.Http;
using Entity;
using Logic;

namespace BrokerRipSite.Controllers
{
    public class SummaryController : ApiController
    {
        private readonly IBrokerRipService _brokerRipService;

        public SummaryController(IBrokerRipService brokerRipService)
        {
            _brokerRipService = brokerRipService;
        }

        public async Task<summary> GetSummary(int percentageTarget)
        {
            return await _brokerRipService.GetBrokerSummary(percentageTarget);
        }
    }
}
