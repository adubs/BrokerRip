BrokerRip
=========

###The short: 
BrokerRip is a framework for aggregating different sources of broker views i.e (http://sharedealing.nandp.co.uk/broker-views/)
and filtering the stocks to those with the desired projected target increase, 

fire the site up with fiddler etc.. at:
/api/summary/{targetPercent} i.e /api/summary/50 and you will get a json response of
all the stocks with a projected target increase of 50% and up.

###The Long:

BrokerRip uses a json schema (http://json-schema.org/) to define a contract of the output format, there is a specflow acceptance
test that validates the site output against the contract.

BrokerRip uses c# 5.0 async-await to pull multiple sources asynchronously, the source could be a json/api or could be screen scraping html,
to a add a new source simply implement IBrokerProvider and add into the structuremap wiring definition.
