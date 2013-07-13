using Logic.Async;
using Logic.BrokerSource;
using StructureMap.Configuration.DSL;

namespace Logic.IoC
{
    public class WiringDefinition : Registry
    {
         public WiringDefinition()
         {
             Init();
         }

        private void Init()
        {
            For<IBrokerRipService>().Use<BrokerRipService>();

            For<ISourceAggregator>().Use<SourceAggregator>();

            // Add multiple broker sources
            For<IBrokerProvider>().Use<NandpBrokerSource>();
            For<IBrokerProvider>().Use<ThisIsMoneyBrokerSource>();
        }
    }
}