using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;
using FluentAssertions;
using Logic;
using Logic.Async;
using NUnit.Framework;
using Rhino.Mocks;

namespace Unit.Async
{
    [TestFixture]
    public class WhenAggregatingSources
    {
        [Test]
        public async void ShouldAggregateAllSources()
        {
            var stubSource = MockRepository.GenerateStub<IBrokerProvider>();
            var stubOthersource = MockRepository.GenerateStub<IBrokerProvider>();

            var brokerRip = new BrokerRip {BrokerName = "broke",StockName = "stock"};
            var otherBrokerRip = new BrokerRip {BrokerName = "bruk", StockName = "otherStock"};

            stubSource.Stub(ss => ss.PullSource()).Return(Task.FromResult(new List<BrokerRip>{brokerRip}));
            stubOthersource.Stub(ss => ss.PullSource()).Return(Task.FromResult(new List<BrokerRip>{otherBrokerRip}));

            var sut = new SourceAggregator(new List<IBrokerProvider>{stubSource, stubOthersource});

            var result = await sut.PullSources();

            result.BrokerRips.Should().Contain(new[] {brokerRip, otherBrokerRip});

        }

        [Test]
        public async void ShouldReturnSourceCount()
        {
            var stubSource = MockRepository.GenerateStub<IBrokerProvider>();
            var stubOthersource = MockRepository.GenerateStub<IBrokerProvider>();

            var brokerRip = new BrokerRip { BrokerName = "broke", StockName = "stock" };
            var otherBrokerRip = new BrokerRip { BrokerName = "bruk", StockName = "otherStock" };

            stubSource.Stub(ss => ss.PullSource()).Return(Task.FromResult(new List<BrokerRip> { brokerRip }));
            stubOthersource.Stub(ss => ss.PullSource()).Return(Task.FromResult(new List<BrokerRip> { otherBrokerRip }));

            var sut = new SourceAggregator(new List<IBrokerProvider> { stubSource, stubOthersource });

            var result = await sut.PullSources();

            Assert.That(result.SourceCount, Is .EqualTo(2));
        }
    }
}