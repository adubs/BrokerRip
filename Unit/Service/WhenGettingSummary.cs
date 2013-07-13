using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;
using FluentAssertions;
using Logic;
using Logic.Async;
using NUnit.Framework;
using Rhino.Mocks;

namespace Unit.Service
{
    [TestFixture]
    public class WhenGettingSummary
    {
        [Test]
        public async void ShouldReturnBrokerSummary()
        {
            var sut = new BrokerRipService(GetStubAggregator());

            var result = await sut.GetBrokerSummary(10);

            Assert.That(result, Is.InstanceOf<summary>());
        }

        [Test]
        public async void ShouldReturnResultsFromAggregator()
        {
            var brokerRips = GetBrokerRips();

            var stubAggregator = MockRepository.GenerateStub<ISourceAggregator>();

            stubAggregator.Stub(s => s.PullSources()).Return( Task.FromResult(new AggregatorResult{BrokerRips =brokerRips, SourceCount = 1}));

            var sut = new BrokerRipService(stubAggregator);

            var result = await sut.GetBrokerSummary(10);

            result.BrokerRips.Should().BeEquivalentTo(brokerRips);
        }

        [Test]
        public async void ShouldReturnSourceCountFromAggregator()
        {
            var stubAggregator = MockRepository.GenerateStub<ISourceAggregator>();

            const int sourceCount = 1;

            stubAggregator.Stub(ag => ag.PullSources())
                          .Return(Task.FromResult(new AggregatorResult{BrokerRips = GetBrokerRips(), SourceCount = sourceCount}));

            var sut = new BrokerRipService(stubAggregator);

            var result = await sut.GetBrokerSummary(10);

            Assert.That(result.SourceCount, Is.EqualTo(sourceCount));
        }

        [Test]
        public async void ShouldFilterStocksToRequestedTargetPercent()
        {
            var rips20 =
                new List<BrokerRip>
                    {
                        new BrokerRip {BrokerName = "broker", TargetIncrease = 20},
                        new BrokerRip {BrokerName = "broker two", TargetIncrease = 25}
                    };

            var rips10 = new List<BrokerRip>
                {
                    new BrokerRip {BrokerName = "broker10", TargetIncrease = 10},
                    new BrokerRip {BrokerName = "anotherbroker10", TargetIncrease = 10}
                };

            var allRips = new List<BrokerRip>();
            allRips.AddRange(rips20);
            allRips.AddRange(rips10);

            var stubAggregator = MockRepository.GenerateStub<ISourceAggregator>();
            stubAggregator.Stub(sa => sa.PullSources())
                          .Return(Task.FromResult(new AggregatorResult{BrokerRips = allRips}));

            var sut = new BrokerRipService(stubAggregator);

            var result = await sut.GetBrokerSummary(20);

            result.BrokerRips.Should().BeEquivalentTo(rips20);
        }


        private static List<BrokerRip> GetBrokerRips()
        {
            var brokerRip1 = new BrokerRip {BrokerName = "somebroker", TargetIncrease = 50};
            var brokerRip2 = new BrokerRip { BrokerName = "anotherbroker", TargetIncrease = 50 };

            var brokerRips = new List<BrokerRip> {brokerRip1, brokerRip2};
            return brokerRips;
        }

        private static ISourceAggregator GetStubAggregator()
        {
            var stubAgg = MockRepository.GenerateStub<ISourceAggregator>();
            stubAgg.Stub(s => s.PullSources())
                   .Return(Task.FromResult(new AggregatorResult {BrokerRips = GetBrokerRips(), SourceCount = 2}));

            return stubAgg;
        }
    }
}