using System;
using System.Collections.Generic;
using System.Linq;
using Acceptance.Utils.BusinessLogic;
using FluentAssertions;
using NUnit.Framework;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using TechTalk.SpecFlow;

namespace Acceptance.Features
{
    [Binding]
    public class SummarySteps
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        [When(@"I Request a Broker Summary")]
        public void WhenIRequestBrokerSummary()
        {
            var response = ScreenScraper.Scrape("http://localhost:49181/api/summary/1"); 
            JObject summary = JObject.Parse(response);

            ScenarioContext.Current["summary"] = summary;
        }


        [Then(@"the summary should conform to the schema")]
        public void ThenTheResultShouldConformToTheSchema()
        {
            IList<string> errors = new List<string>();

            var contract = ScreenScraper.Scrape("http://localhost:49181/contract.txt");
            
            JObject jSchema = JObject.Parse(contract);

            var stringSchema = jSchema["operations"]["summary"]["returns"]["schema"].ToString();
            JsonSchema schema = JsonSchema.Parse(stringSchema);

            var summary = ScenarioContext.Current["summary"] as JObject;

            bool valid = summary.IsValid(schema, out errors);

           // if (!valid && errors.Any())
                //throw new Exception(errors[0]);

            string contractErrors = errors.Aggregate(string.Empty, (current, error) => current + (error + ", "));

            Assert.IsTrue(valid, contractErrors);
        }


    }
}