Feature: BrokerRip
	In order to quickly Look up stocks recommended by brokers
	As a busy person
	I want to be given a summary from multiple brokers view sites

@mytag
Scenario: Get Broker Rip Summary
	When I Request a Broker Summary	
	Then the summary should conform to the schema
