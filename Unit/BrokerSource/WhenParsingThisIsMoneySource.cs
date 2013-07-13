using System;
using System.Collections.Generic;
using Entity;
using Logic.BrokerSource;
using NUnit.Framework;

namespace Unit.BrokerSource
{
    [TestFixture]
    public class WhenParsingThisIsMoneySource
    {
        [Test]
        public void ReturnValueShouldBeListOfBrokerRips()
        {
            string pageString = GetPageText();
            var sut = new ThisIsMoneyParser();

            var result = sut.Parse(pageString);

            Assert.That(result, Is.InstanceOf<List<BrokerRip>>());
        }

        [Test]
        public void ShouldReturnAllViews()
        {
            var result = parsePage();

            Assert.That(result.Count, Is.EqualTo(127));
        }

        private List<BrokerRip> parsePage()
        {
            string pageString = GetPageText();
            var sut = new ThisIsMoneyParser();

            var result = sut.Parse(pageString);

            return result;
        }

        [Test]
        public void ShouldParseStockName()
        {
            var result = parsePage();

            Assert.That(result[0].StockName, Is.EqualTo("Cobham PLC"));
        }

        [Test]
        public void ShouldParseBrokerName()
        {
            var result = parsePage();

            Assert.That(result[0].BrokerName, Is.EqualTo("Morgan Stanley"));
        }

        [Test]
        public void ShouldCalculateTargetPercentageIncrease()
        {
            var result = parsePage();
            var increase = Math.Round((195.00 - 286.90) / 286.90 * 100);

            Assert.That(result[0].TargetIncrease, Is.EqualTo(increase));
        }
        

        private string GetPageText()
        {
            return @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xml:lang=""en"" lang=""en"">
<head>
    
    
    <title>Broker Views | This is Money</title>
    <meta name=""verify-v1"" content=""DXwlrsxbqxSv+FTFkWUfgflBvFJfx2YbNf/HmABrVyY=""/>
    <meta name=""msvalidate.01"" content=""12E6B4B813EB44C9BFC8F6A21F1D01F5""/>
    <meta name=""y_key"" content=""1a7e912afbfcab2f""/>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8""/>
    <meta http-equiv=""Content-Language"" content=""en""/>
    <meta http-equiv=""X-UA-Compatible"" content=""IE=7""/>
    <meta http-equiv=""imagetoolbar"" content=""false""/>
    <meta name=""MSSmartTagsPreventParsing"" content=""true""/>
    <meta name=""Rating"" content=""General""/>
    <meta name=""doc-class"" content=""Living Document""/>
    <meta name=""robots"" content=""noodp,noydir,all""/>
    
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://scripts.dailymail.co.uk/static/bundles/all--46-FIX-SNAPSHOT-build-212.css""/>
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://i.dailymail.co.uk/midas/coloursCss.css""/>

    <!--[if lte IE 6]>
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""http://scripts.dailymail.co.uk/static/bundles/ie6--45-FIX-SNAPSHOT-build-195.css""/>
    <![endif]-->

    <link rel=""stylesheet"" type=""text/css"" media=""print"" href=""http://scripts.dailymail.co.uk/static/bundles/print--45-FIX-SNAPSHOT-build-195.css""/>
<link href=""/css/tim.css?20130605_153042"" media=""screen"" rel=""stylesheet"" type=""text/css"" >
<link href=""/css/poshytip-yellow.css"" media=""screen"" rel=""stylesheet"" type=""text/css"" >
<link href=""/broker-views/"" rel=""canonical"" ><script type=""text/javascript"" src=""/js/jquery-1.4.2.min.js""></script>
<script type=""text/javascript"" src=""/js/jquery.autocomplete.pack.js""></script>
<script type=""text/javascript"" src=""/js/jquery.tablesorter.min.js""></script>
<script type=""text/javascript"" src=""/js/jquery.validate.pack.js""></script>
<script type=""text/javascript"" src=""/js/jquery.poshytip.min.js""></script>
<script type=""text/javascript"" src=""/js/amcharts.js?20130605_153042""></script>
<script type=""text/javascript"" src=""/js/moneyam.js?20130605_153042""></script>
<script type=""text/javascript"" src=""/flash/amline/swfobject.js""></script>
<script type=""text/javascript"" src=""/js/googleanalytics.js""></script></head>
<body id=""money"" class=""moneymoney"">
	<script type=""text/javascript"" src=""http://scripts.dailymail.co.uk/tracking/DMLog.js""></script>
	<script type=""text/javascript"">
		var loc = window.location;
		DM_log('money', {
			domain: loc.hostname,
			pageName: loc.hostname + loc.pathname,
			prop2: 'money/marketdata',
			prop4: 'marketdata'
       });
	</script>
	<!-- Begin comScore Inline Tag 1.1111.15 -->
	
	<script type=""text/javascript"">
		// <![CDATA[
			function udm_(a){var b=""comScore="",c=document,d=c.cookie,e="""",f=""indexOf"",g=""substring"",h=""length"",i=2048,j,k=""&ns_"",l=""&"",m,n,o,p,q=window,r=q.encodeURIComponent||escape;if(d[f](b)+1)for(o=0,n=d.split("";""),p=n[h];o<p;o++)m=n[o][f](b),m+1&&(e=l+unescape(n[o][g](m+b[h])));a+=k+""_t=""+ +(new Date)+k+""c=""+(c.characterSet||c.defaultCharset||"""")+""&c8=""+r(c.title)+e+""&c7=""+r(c.URL)+""&c9=""+r(c.referrer),a[h]>i&&a[f](l)>0&&(j=a[g](0,i-8).lastIndexOf(l),a=(a[g](0,j)+k+""cut=""+r(a[g](j+1)))[g](0,i)),c.images?(m=new Image,q.ns_p||(ns_p=m),m.src=a):c.write(""<"",""p"",""><"",'img src=""',a,'"" height=""1"" width=""1"" alt=""*""',""><"",""/p"","">"")}
			udm_('http'+(document.location.href.charAt(4)=='s'?'s://sb':'://b')+'.scorecardresearch.com/b?c1=2&c2=14366613&name=money.investing.broker-views.page');
		// ]]>
	</script>
	
	<noscript><p><img src=""http://b.scorecardresearch.com/p?c1=2&c2=14366613&name=money.investing.broker-views.page"" height=""1"" width=""1"" alt=""*""></p></noscript>
	<!-- End comScore Inline Tag -->
    <a href=""#top"" name=""top""></a>
    <ul class=""usability"">
        <li><a href=""#navigation"" accesskey=""1"">Skip to main navigation</a></li>
        <li><a href=""#content"" accesskey=""2"">Skip to main content</a></li>
        <li><a href=""#search"" accesskey=""4"">Skip to search</a></li>
    </ul>
    <div class=""page headeronly "">
        <div id=""page-container"">
        		<div id=""page-leaderboard"">
						<script type=""text/javascript"" src=""http://ad.uk.doubleclick.net/adj/thisismoney.uk/tim_timmoney_moneymarkets;area=money;subarea=moneymarkets;target=;page=hp;article=;content=;section=;referrer=;environment=production;tile=1;sz=468x60,728x90,900x125;ord=1373711665?""></script>
					</div>
            <div class=""clear"">&nbsp;</div>
            <div class=""page-header bdrgr2"">
                <div class=""money"">
	                <div class=""masthead "">
						<a href=""http://www.thisismoney.co.uk""><img src=""http://i.dailymail.co.uk/i/sitelogos/logo_tim.png"" width=""430"" height=""80"" alt=""MailOnline - news, sport, celebrity, science and health stories"" id=""logo"" style=""top:0px;""></a>
						<div align=""right""><img src=""http://i.dailymail.co.uk/i/pix/tim_channelheaders/marketdata_tim_masthead.png""/></div>
					</div>
                </div>
                <div class=""money"">
                    <div class=""nav-secondary wocc link-lccox cleared bdrgr3 border-top "">
                        <ul class=""float-l"">
                            <li class=""first"">
                                <a href=""http://www.thisismoney.co.uk/money/index.html"" target=""_top"" class='current'>Money Home</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/markets/index.html"" target=""_top"" target=""_top"">Markets</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/saving/index.html"" target=""_top"" target=""_top"">Saving</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/investing/index.html"" target=""_top"" target=""_top"">Investing</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/bills/index.html"" target=""_top"" target=""_top"">Bills</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/cars/index.html"" target=""_top"" target=""_top"">Cars</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/holidays/index.html"" target=""_top"" target=""_top"">Holidays</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/cardsloans/index.html"" target=""_top"" target=""_top"">Cards & loans</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/pensions/index.html"" target=""_top"" target=""_top"">Pensions</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/mortgageshome/index.html"" target=""_top"" target=""_top"">Mortgages & home</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/experts/index.html"" target=""_top"" target=""_top"">Experts</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>

		<div class=""tim-tools cleared bogr2 cnr5"">
    		<div class=""tim-tools-iframe"">
    			<iframe width=""285"" scrolling=""no"" height=""45"" frameborder=""0"" src=""/modules/header-market""></iframe>
			</div>

			<iframe style=""float: left;margin-left:10px"" scrolling=""no"" height=""45"" frameborder=""0"" src=""http://www.dailymail.co.uk/ce/item.cms?itemId=1001189&itemType=linkListGroup&versionId=0&styleId=48&ddGroup=1&contenteditor=true&decorator=contenteditor""></iframe>

			<div class=""tim-search"" style=""float:right;font-size:12px;"">
				<form method=""get"" action=""http://www.thisismoney.co.uk/money/search.html"" id=""rcp-search"" onsubmit=""document.getElementById('q').value=document.getElementById('rcp-phrase').value;"">
					<fieldset>
			       		<label class=""usability"" for=""rcp-phrase"">Enter search term:</label>
				        <input type=""text"" value="""" alt=""Enter a search term"" name=""searchPhrase"" class=""textinp"" id=""rcp-phrase"" />
				        <input name=""channelshortname"" type=""hidden"" value=""money"" />
				        <input name=""q"" id=""q"" type=""hidden"" value="""" />
						<span class=""tim-btn"">
			          		<button type=""submit"">
			   					<span></span>Search
			           		</button>
			       		</span>
			       		<div class=""gr5ox"">
			           		<input type=""radio"" class=""ie-radio"" checked=""checked"" value=""article"" name=""searchWhere"" id=""rcp-article"" onclick=""this.form.action='http://int.thisismoney.co.uk/money/search.html'""/>
			           		<label for=""rcp-article"">All Articles</label>
							<input type=""radio"" class=""ie-radio"" value=""company"" name=""searchWhere"" id=""rcp-company"" onclick=""this.form.action='http://investing.thisismoney.co.uk/search/'""/>
			           		<label for=""rcp-company"">Share prices</label>
			       		</div>
			    	</fieldset>
				</form>
			</div>
		    <span class=""bl""></span>
    		<span class=""br""></span>
		</div>

        <div id=""content"" class=""generic cleared""><div class=""gamma"">

	<div class=""ccogr1 pad10 bot1"">
		<h1>Broker Views </h1>
		<span class=""tl"">&nbsp;</span>
		<span class=""tr"">&nbsp;</span>
	</div>

	<div class=""ccogr1 pad10 bot20"">
		<h3 class=""subheading bot10"">This table is a guide to the latest buy, sell, hold and target price forecasts from the big City banks and brokers.</h3>
		<span class=""bl"">&nbsp;</span>
		<span class=""br"">&nbsp;</span>
	</div>

	<div class=""market-table bot20"">
		<table class=""sortable white-header"" cellpadding=""0"" cellspacing=""0"" id=""broker-views-table"">
			<thead>
				<tr>
					<th class=""center"">Date</th>
					<th>Company Name</th>
					<th>EPIC</th>
					<th>Broker</th>
					<th>Recommendation</th>
					<th>Current Price</th>
					<th>Price when issued</th>
					<th>Old target price</th>
					<th>New target price</th>
					<th>Notes</th>
				</tr>
			</thead>
			<tbody>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/COB/Cobham-PLC-share-price"">Cobham PLC</a></td>
					<td>COB</td>
					<td>Morgan Stanley</td>
					<td>Underweight</td>
					<td>286.90</td>
					<td>288.30</td>
					<td>195.00</td>
					<td>195.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BA./BAE-Systems-Plc-share-price"">BAE Systems Plc</a></td>
					<td>BA.</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>423.40</td>
					<td>422.10</td>
					<td>350.00</td>
					<td>350.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RR./Rolls-Royce-Group-PLC-share-price"">Rolls-Royce Group...</a></td>
					<td>RR.</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>1,203.00</td>
					<td>1,202.00</td>
					<td>1,300.00</td>
					<td>1,300.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SPRT/Spirit-Pub-share-price"">Spirit Pub</a></td>
					<td>SPRT</td>
					<td>Morgan Stanley</td>
					<td>Underweight</td>
					<td>68.25</td>
					<td>66.00</td>
					<td>55.00</td>
					<td>55.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/LAD/Ladbrokes-PLC-share-price"">Ladbrokes PLC</a></td>
					<td>LAD</td>
					<td>Morgan Stanley</td>
					<td>Underweight</td>
					<td>206.70</td>
					<td>209.30</td>
					<td>165.00</td>
					<td>165.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/TT./TUI-Travel-PLC-share-price"">TUI Travel PLC</a></td>
					<td>TT.</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>374.10</td>
					<td>370.80</td>
					<td>320.00</td>
					<td>320.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RNK/Rank-Group-The-PLC-share-price"">Rank Group (The) PLC</a></td>
					<td>RNK</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>163.00</td>
					<td>165.00</td>
					<td>200.00</td>
					<td>200.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/MLC/Millennium-Copthorne-Hotels-PLC-share-price"">Millennium &...</a></td>
					<td>MLC</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>550.00</td>
					<td>551.50</td>
					<td>640.00</td>
					<td>640.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/MAB/Mitchells-Butlers-PLC-share-price"">Mitchells &...</a></td>
					<td>MAB</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>400.50</td>
					<td>396.50</td>
					<td>380.00</td>
					<td>380.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/WTB/Whitbread-PLC-share-price"">Whitbread PLC</a></td>
					<td>WTB</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>3,195.00</td>
					<td>3,177.00</td>
					<td>2,900.00</td>
					<td>2,900.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CPG/Compass-Group-PLC-share-price"">Compass Group PLC</a></td>
					<td>CPG</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>896.50</td>
					<td>894.00</td>
					<td>830.00</td>
					<td>830.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/JDW/Wetherspoon-J-D-PLC-share-price"">Wetherspoon (J D)...</a></td>
					<td>JDW</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>668.50</td>
					<td>667.00</td>
					<td>580.00</td>
					<td>580.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CCL/Carnival-PLC-share-price"">Carnival PLC</a></td>
					<td>CCL</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>2,457.00</td>
					<td>2,452.00</td>
					<td>2,200.00</td>
					<td>2,200.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BPTY/bwinparty-digital-entertainment-PLC-share-price"">bwin.party...</a></td>
					<td>BPTY</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>126.10</td>
					<td>127.80</td>
					<td>180.00</td>
					<td>180.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/888/888-Holdings-PLC-share-price"">888 Holdings PLC</a></td>
					<td>888</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>153.90</td>
					<td>155.00</td>
					<td>175.00</td>
					<td>175.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BET/Betfair-Group-share-price"">Betfair Group</a></td>
					<td>BET</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>864.00</td>
					<td>853.50</td>
					<td>1,000.00</td>
					<td>1,000.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ETI/Enterprise-Inns-PLC-share-price"">Enterprise Inns PLC</a></td>
					<td>ETI</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>124.70</td>
					<td>125.30</td>
					<td>140.00</td>
					<td>140.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/WMH/William-Hill-PLC-share-price"">William Hill PLC</a></td>
					<td>WMH</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>464.20</td>
					<td>463.50</td>
					<td>420.00</td>
					<td>420.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PTEC/Playtech-Ltd-share-price"">Playtech Ltd</a></td>
					<td>PTEC</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>650.00</td>
					<td>648.00</td>
					<td>800.00</td>
					<td>800.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/TCG/Thomas-Cook-Group-PLC-share-price"">Thomas Cook Group...</a></td>
					<td>TCG</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>141.30</td>
					<td>139.50</td>
					<td>160.00</td>
					<td>160.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/IHG/InterContinental-Hotels-Group-PLC-share-price"">InterContinental...</a></td>
					<td>IHG</td>
					<td>Morgan Stanley</td>
					<td>Overweight</td>
					<td>1,962.00</td>
					<td>1,962.00</td>
					<td>2,300.00</td>
					<td>2,300.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BG./BG-Group-PLC-share-price"">BG Group PLC</a></td>
					<td>BG.</td>
					<td>RBC Capital Markets</td>
					<td>Outperform</td>
					<td>1,177.50</td>
					<td>1,173.00</td>
					<td>1,400.00</td>
					<td>1,400.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/LSE/London-Stock-Exchange-Group-PLC-share-price"">London Stock...</a></td>
					<td>LSE</td>
					<td>RBC Capital Markets</td>
					<td>Outperform</td>
					<td>1,465.00</td>
					<td>1,490.00</td>
					<td>1,600.00</td>
					<td>1,600.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/GFS/G4S-PLC-share-price"">G4S PLC</a></td>
					<td>GFS</td>
					<td>Cantor Fitzgerald</td>
					<td>Hold</td>
					<td>209.45</td>
					<td>213.00</td>
					<td>315.00</td>
					<td>220.00</td>
					<td>Downgrades</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BAB/Babcock-International-Group-PLC-share-price"">Babcock...</a></td>
					<td>BAB</td>
					<td>Beaufort Securities</td>
					<td>Hold</td>
					<td>1,173.00</td>
					<td>1,176.00</td>
					<td>-</td>
					<td>-</td>
					<td>Downgrades</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CRDA/Croda-International-PLC-share-price"">Croda...</a></td>
					<td>CRDA</td>
					<td>Bank of America Merrill Lynch</td>
					<td>Buy</td>
					<td>2,601.00</td>
					<td>2,600.00</td>
					<td>2,900.00</td>
					<td>2,870.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/VCT/Victrex-PLC-share-price"">Victrex PLC</a></td>
					<td>VCT</td>
					<td>Bank of America Merrill Lynch</td>
					<td>Underperform</td>
					<td>1,637.00</td>
					<td>1,644.00</td>
					<td>1,460.00</td>
					<td>1,400.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/JMAT/Johnson-Matthey-PLC-share-price"">Johnson Matthey PLC</a></td>
					<td>JMAT</td>
					<td>Bank of America Merrill Lynch</td>
					<td>Buy</td>
					<td>2,833.00</td>
					<td>2,807.00</td>
					<td>2,950.00</td>
					<td>2,950.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ELM/Elementis-PLC-share-price"">Elementis PLC</a></td>
					<td>ELM</td>
					<td>Bank of America Merrill Lynch</td>
					<td>Underperform</td>
					<td>235.90</td>
					<td>223.10</td>
					<td>210.00</td>
					<td>210.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SYNT/Synthomer-share-price"">Synthomer</a></td>
					<td>SYNT</td>
					<td>Bank of America Merrill Lynch</td>
					<td>Neutral</td>
					<td>195.90</td>
					<td>196.20</td>
					<td>210.00</td>
					<td>210.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ASHM/Ashmore-Group-PLC-share-price"">Ashmore Group PLC</a></td>
					<td>ASHM</td>
					<td>Societe Generale</td>
					<td>Buy</td>
					<td>371.45</td>
					<td>376.70</td>
					<td>430.00</td>
					<td>450.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ISYS/Invensys-PLC-share-price"">Invensys PLC</a></td>
					<td>ISYS</td>
					<td>Societe Generale</td>
					<td>Buy</td>
					<td>508.00</td>
					<td>440.10</td>
					<td>445.00</td>
					<td>445.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ABF/Associated-British-Foods-PLC-share-price"">Associated...</a></td>
					<td>ABF</td>
					<td>Societe Generale</td>
					<td>Sell</td>
					<td>1,879.00</td>
					<td>1,907.00</td>
					<td>1,900.00</td>
					<td>1,900.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/MPI/Michael-Page-International-PLC-share-price"">Michael Page...</a></td>
					<td>MPI</td>
					<td>Investec</td>
					<td>Sell</td>
					<td>422.00</td>
					<td>417.50</td>
					<td>385.00</td>
					<td>385.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RWA/Robert-Walters-PLC-share-price"">Robert Walters PLC</a></td>
					<td>RWA</td>
					<td>Investec</td>
					<td>Buy</td>
					<td>220.00</td>
					<td>212.50</td>
					<td>235.00</td>
					<td>248.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RIO/Rio-Tinto-PLC-share-price"">Rio Tinto PLC</a></td>
					<td>RIO</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>2,799.00</td>
					<td>2,833.50</td>
					<td>3,590.00</td>
					<td>3,590.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ECM/Electrocomponents-PLC-share-price"">Electrocomponents...</a></td>
					<td>ECM</td>
					<td>RBC Capital Markets</td>
					<td>Sector Performer</td>
					<td>252.20</td>
					<td>253.40</td>
					<td>260.00</td>
					<td>260.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PMO/Premier-Oil-PLC-share-price"">Premier Oil PLC</a></td>
					<td>PMO</td>
					<td>RBC Capital Markets</td>
					<td>Outperform</td>
					<td>362.60</td>
					<td>358.30</td>
					<td>-</td>
					<td>-</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/INTQ/InternetQ-PLC-share-price"">InternetQ PLC</a></td>
					<td>INTQ</td>
					<td>RBC Capital Markets</td>
					<td>Outperform</td>
					<td>324.50</td>
					<td>329.00</td>
					<td>-</td>
					<td>-</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HAS/Hays-PLC-share-price"">Hays PLC</a></td>
					<td>HAS</td>
					<td>RBC Capital Markets</td>
					<td>Sector Performer</td>
					<td>100.70</td>
					<td>99.90</td>
					<td>94.00</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/AUE/Aureus-Mining-share-price"">Aureus Mining</a></td>
					<td>AUE</td>
					<td>RBC Capital Markets</td>
					<td>Outperform</td>
					<td>26.25</td>
					<td>25.25</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ASHM/Ashmore-Group-PLC-share-price"">Ashmore Group PLC</a></td>
					<td>ASHM</td>
					<td>RBC Capital Markets</td>
					<td>Sector Performer</td>
					<td>371.45</td>
					<td>376.70</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BBY/Balfour-Beatty-PLC-share-price"">Balfour Beatty PLC</a></td>
					<td>BBY</td>
					<td>RBC Capital Markets</td>
					<td>Sector Performer</td>
					<td>220.70</td>
					<td>225.70</td>
					<td>220.00</td>
					<td>200.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PTEC/Playtech-Ltd-share-price"">Playtech Ltd</a></td>
					<td>PTEC</td>
					<td>JP Morgan Cazenove</td>
					<td>Overweight</td>
					<td>650.00</td>
					<td>648.00</td>
					<td>800.00</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SRP/Serco-Group-PLC-share-price"">Serco Group PLC</a></td>
					<td>SRP</td>
					<td>JP Morgan Cazenove</td>
					<td>Overweight</td>
					<td>620.50</td>
					<td>626.50</td>
					<td>-</td>
					<td>-</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/GFS/G4S-PLC-share-price"">G4S PLC</a></td>
					<td>GFS</td>
					<td>JP Morgan Cazenove</td>
					<td>Overweight</td>
					<td>209.45</td>
					<td>213.00</td>
					<td>-</td>
					<td>-</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BAB/Babcock-International-Group-PLC-share-price"">Babcock...</a></td>
					<td>BAB</td>
					<td>JP Morgan Cazenove</td>
					<td>Overweight</td>
					<td>1,173.00</td>
					<td>1,176.00</td>
					<td>1,380.00</td>
					<td>1,380.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ABF/Associated-British-Foods-PLC-share-price"">Associated...</a></td>
					<td>ABF</td>
					<td>JP Morgan Cazenove</td>
					<td>Overweight</td>
					<td>1,879.00</td>
					<td>1,907.00</td>
					<td>2,000.00</td>
					<td>2,000.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HAS/Hays-PLC-share-price"">Hays PLC</a></td>
					<td>HAS</td>
					<td>JP Morgan Cazenove</td>
					<td>Neutral</td>
					<td>100.70</td>
					<td>99.90</td>
					<td>90.40</td>
					<td>102.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ASHM/Ashmore-Group-PLC-share-price"">Ashmore Group PLC</a></td>
					<td>ASHM</td>
					<td>JP Morgan Cazenove</td>
					<td>Neutral</td>
					<td>371.45</td>
					<td>376.70</td>
					<td>339.00</td>
					<td>377.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BRBY/Burberry-Group-PLC-share-price"">Burberry Group PLC</a></td>
					<td>BRBY</td>
					<td>Credit Suisse</td>
					<td>Outperform</td>
					<td>1,515.50</td>
					<td>1,524.00</td>
					<td>1,600.00</td>
					<td>1,700.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RB./Reckitt-Benckiser-Group-PLC-share-price"">Reckitt Benckiser...</a></td>
					<td>RB.</td>
					<td>Credit Suisse</td>
					<td>Neutral</td>
					<td>4,677.00</td>
					<td>4,929.00</td>
					<td>4,900.00</td>
					<td>4,650.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/STJ/St-Jamess-Place-PLC-share-price"">St James's Place PLC</a></td>
					<td>STJ</td>
					<td>Nomura</td>
					<td>Buy</td>
					<td>597.00</td>
					<td>581.00</td>
					<td>370.00</td>
					<td>668.00</td>
					<td>Upgrades</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SL./Standard-Life-PLC-share-price"">Standard Life PLC</a></td>
					<td>SL.</td>
					<td>Nomura</td>
					<td>Reduce</td>
					<td>384.70</td>
					<td>379.00</td>
					<td>260.00</td>
					<td>351.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RSL/Resolution-Ltd-share-price"">Resolution Ltd</a></td>
					<td>RSL</td>
					<td>Nomura</td>
					<td>Neutral</td>
					<td>318.50</td>
					<td>308.00</td>
					<td>250.00</td>
					<td>311.00</td>
					<td>Upgrades</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PRU/Prudential-PLC-share-price"">Prudential PLC</a></td>
					<td>PRU</td>
					<td>Nomura</td>
					<td>Buy</td>
					<td>1,118.00</td>
					<td>1,110.00</td>
					<td>680.00</td>
					<td>1,392.00</td>
					<td>Upgrades</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/LGEN/Legal-General-Group-PLC-share-price"">Legal & General...</a></td>
					<td>LGEN</td>
					<td>Nomura</td>
					<td>Neutral</td>
					<td>186.20</td>
					<td>189.10</td>
					<td>185.00</td>
					<td>188.00</td>
					<td>Downgrades</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/AV./Aviva-PLC-share-price"">Aviva PLC</a></td>
					<td>AV.</td>
					<td>Nomura</td>
					<td>Buy</td>
					<td>360.40</td>
					<td>364.00</td>
					<td>540.00</td>
					<td>414.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RB./Reckitt-Benckiser-Group-PLC-share-price"">Reckitt Benckiser...</a></td>
					<td>RB.</td>
					<td>Nomura</td>
					<td>Buy</td>
					<td>4,677.00</td>
					<td>4,929.00</td>
					<td>4,900.00</td>
					<td>4,800.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BARC/Barclays-PLC-share-price"">Barclays PLC</a></td>
					<td>BARC</td>
					<td>Numis</td>
					<td>Reduce</td>
					<td>306.15</td>
					<td>302.90</td>
					<td>-</td>
					<td>272.00</td>
					<td>Downgrades</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/OXIG/Oxford-Instruments-PLC-share-price"">Oxford...</a></td>
					<td>OXIG</td>
					<td>N+1 Singer</td>
					<td>Hold</td>
					<td>1,370.00</td>
					<td>1,250.00</td>
					<td>1,390.00</td>
					<td>1,390.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/NPT/NetPlay-TV-PLC-share-price"">NetPlay TV PLC</a></td>
					<td>NPT</td>
					<td>N+1 Singer</td>
					<td>Corporate</td>
					<td>17.75</td>
					<td>17.50</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/MMP/Marwyn-Management-Partners-PLC-share-price"">Marwyn Management...</a></td>
					<td>MMP</td>
					<td>N+1 Singer</td>
					<td>Corporate</td>
					<td>11.00</td>
					<td>10.75</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/EMIS/EMIS-Group-PLC-share-price"">EMIS Group PLC</a></td>
					<td>EMIS</td>
					<td>N+1 Singer</td>
					<td>Hold</td>
					<td>760.25</td>
					<td>751.00</td>
					<td>780.00</td>
					<td>780.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CSG/Sweett-Group-PLC-share-price"">Sweett Group PLC</a></td>
					<td>CSG</td>
					<td>Westhouse Securities</td>
					<td>Buy</td>
					<td>23.50</td>
					<td>23.00</td>
					<td>45.00</td>
					<td>45.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CAU/Centaur-Media-PLC-share-price"">Centaur Media PLC</a></td>
					<td>CAU</td>
					<td>Westhouse Securities</td>
					<td>Neutral</td>
					<td>40.75</td>
					<td>38.75</td>
					<td>38.00</td>
					<td>38.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HAWK/Nighthawk-Energy-PLC-share-price"">Nighthawk Energy PLC</a></td>
					<td>HAWK</td>
					<td>Westhouse Securities</td>
					<td>Buy</td>
					<td>6.19</td>
					<td>6.05</td>
					<td>10.70</td>
					<td>10.70</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ITE/ITE-Group-PLC-share-price"">ITE Group PLC</a></td>
					<td>ITE</td>
					<td>Westhouse Securities</td>
					<td>Neutral</td>
					<td>302.00</td>
					<td>300.30</td>
					<td>285.00</td>
					<td>285.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SRP/Serco-Group-PLC-share-price"">Serco Group PLC</a></td>
					<td>SRP</td>
					<td>Westhouse Securities</td>
					<td>Neutral</td>
					<td>620.50</td>
					<td>626.50</td>
					<td>630.00</td>
					<td>630.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BYG/Big-Yellow-Group-Plc-share-price"">Big Yellow Group Plc</a></td>
					<td>BYG</td>
					<td>Beaufort Securities</td>
					<td>Sell</td>
					<td>428.80</td>
					<td>431.80</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PMO/Premier-Oil-PLC-share-price"">Premier Oil PLC</a></td>
					<td>PMO</td>
					<td>Beaufort Securities</td>
					<td>Buy</td>
					<td>362.60</td>
					<td>358.30</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/MONY/Moneysupermarketcom-Group-PLC-share-price"">Moneysupermarket....</a></td>
					<td>MONY</td>
					<td>Beaufort Securities</td>
					<td>Hold</td>
					<td>201.20</td>
					<td>200.10</td>
					<td>-</td>
					<td>-</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/EMIS/EMIS-Group-PLC-share-price"">EMIS Group PLC</a></td>
					<td>EMIS</td>
					<td>Sanlam Securities</td>
					<td>Hold</td>
					<td>760.25</td>
					<td>751.00</td>
					<td>700.00</td>
					<td>700.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/GPOR/Great-Portland-Estates-PLC-share-price"">Great Portland...</a></td>
					<td>GPOR</td>
					<td>Exane BNP Paribas</td>
					<td>Neutral</td>
					<td>581.00</td>
					<td>583.00</td>
					<td>560.00</td>
					<td>560.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SHB/Shaftesbury-share-price"">Shaftesbury</a></td>
					<td>SHB</td>
					<td>Exane BNP Paribas</td>
					<td>Underperform</td>
					<td>640.50</td>
					<td>644.50</td>
					<td>540.00</td>
					<td>540.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/DLN/Derwent-London-share-price"">Derwent London</a></td>
					<td>DLN</td>
					<td>Exane BNP Paribas</td>
					<td>Neutral</td>
					<td>2,495.00</td>
					<td>2,495.00</td>
					<td>2,220.00</td>
					<td>2,300.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CAPC/Capital-Counties-Properties-PLC-share-price"">Capital &...</a></td>
					<td>CAPC</td>
					<td>Exane BNP Paribas</td>
					<td>Outperform</td>
					<td>355.40</td>
					<td>355.60</td>
					<td>414.00</td>
					<td>415.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SGRO/Segro-share-price"">Segro</a></td>
					<td>SGRO</td>
					<td>Exane BNP Paribas</td>
					<td>Underperform</td>
					<td>299.90</td>
					<td>298.80</td>
					<td>260.00</td>
					<td>270.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/INTU/Intu-Properties-share-price"">Intu Properties</a></td>
					<td>INTU</td>
					<td>Exane BNP Paribas</td>
					<td>Underperform</td>
					<td>328.70</td>
					<td>331.30</td>
					<td>330.00</td>
					<td>300.00</td>
					<td>Downgrades</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HMSO/Hammerson-share-price"">Hammerson</a></td>
					<td>HMSO</td>
					<td>Exane BNP Paribas</td>
					<td>Outperform</td>
					<td>531.00</td>
					<td>540.00</td>
					<td>600.00</td>
					<td>580.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BLND/British-Land-Co-PLC-share-price"">British Land Co PLC</a></td>
					<td>BLND</td>
					<td>Exane BNP Paribas</td>
					<td>Neutral</td>
					<td>614.50</td>
					<td>617.50</td>
					<td>600.00</td>
					<td>590.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/LAND/Land-Securities-Group-Plc-share-price"">Land Securities...</a></td>
					<td>LAND</td>
					<td>Exane BNP Paribas</td>
					<td>Neutral</td>
					<td>963.00</td>
					<td>972.00</td>
					<td>940.00</td>
					<td>930.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HAS/Hays-PLC-share-price"">Hays PLC</a></td>
					<td>HAS</td>
					<td>Exane BNP Paribas</td>
					<td>Outperform</td>
					<td>100.70</td>
					<td>99.90</td>
					<td>107.00</td>
					<td>107.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ITV/ITV-PLC-share-price"">ITV PLC</a></td>
					<td>ITV</td>
					<td>Exane BNP Paribas</td>
					<td>Outperform</td>
					<td>157.90</td>
					<td>154.00</td>
					<td>-</td>
					<td>170.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/GFS/G4S-PLC-share-price"">G4S PLC</a></td>
					<td>GFS</td>
					<td>Exane BNP Paribas</td>
					<td>Neutral</td>
					<td>209.45</td>
					<td>213.00</td>
					<td>280.00</td>
					<td>240.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BARC/Barclays-PLC-share-price"">Barclays PLC</a></td>
					<td>BARC</td>
					<td>Exane BNP Paribas</td>
					<td>Outperform</td>
					<td>306.15</td>
					<td>302.90</td>
					<td>400.00</td>
					<td>380.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CCAP/Charlemagne-Capital-Ltd-share-price"">Charlemagne...</a></td>
					<td>CCAP</td>
					<td>N+1 Singer</td>
					<td>Corporate</td>
					<td>11.00</td>
					<td>12.00</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/WOS/Wolseley-PLC-share-price"">Wolseley PLC</a></td>
					<td>WOS</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>3,260.50</td>
					<td>3,258.00</td>
					<td>3,400.00</td>
					<td>3,400.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/TPK/Travis-Perkins-PLC-share-price"">Travis Perkins PLC</a></td>
					<td>TPK</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>1,633.00</td>
					<td>1,636.00</td>
					<td>1,213.00</td>
					<td>1,213.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SHI/SIG-PLC-share-price"">SIG PLC</a></td>
					<td>SHI</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>175.10</td>
					<td>169.80</td>
					<td>153.00</td>
					<td>153.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RDW/Redrow-PLC-share-price"">Redrow PLC</a></td>
					<td>RDW</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>240.70</td>
					<td>237.50</td>
					<td>241.00</td>
					<td>241.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PSN/Persimmon-PLC-share-price"">Persimmon PLC</a></td>
					<td>PSN</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>1,293.00</td>
					<td>1,276.00</td>
					<td>1,202.00</td>
					<td>1,202.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BWY/Bellway-PLC-share-price"">Bellway PLC</a></td>
					<td>BWY</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>1,448.00</td>
					<td>1,420.00</td>
					<td>1,503.00</td>
					<td>1,503.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BVS/Bovis-Homes-Group-PLC-share-price"">Bovis Homes Group...</a></td>
					<td>BVS</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>849.50</td>
					<td>843.00</td>
					<td>900.00</td>
					<td>900.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BKG/Berkeley-Group-Holdings-The-PLC-share-price"">Berkeley Group...</a></td>
					<td>BKG</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>2,325.00</td>
					<td>2,315.00</td>
					<td>2,252.00</td>
					<td>2,252.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BBY/Balfour-Beatty-PLC-share-price"">Balfour Beatty PLC</a></td>
					<td>BBY</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>220.70</td>
					<td>225.70</td>
					<td>220.00</td>
					<td>220.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/TW./Taylor-Wimpey-PLC-share-price"">Taylor Wimpey PLC</a></td>
					<td>TW.</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>105.40</td>
					<td>104.00</td>
					<td>113.00</td>
					<td>113.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BDEV/Barratt-Developments-PLC-share-price"">Barratt...</a></td>
					<td>BDEV</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>351.00</td>
					<td>346.80</td>
					<td>365.00</td>
					<td>365.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/GFS/G4S-PLC-share-price"">G4S PLC</a></td>
					<td>GFS</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>209.45</td>
					<td>213.00</td>
					<td>250.00</td>
					<td>212.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SRP/Serco-Group-PLC-share-price"">Serco Group PLC</a></td>
					<td>SRP</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>620.50</td>
					<td>626.50</td>
					<td>600.00</td>
					<td>630.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SGRO/Segro-share-price"">Segro</a></td>
					<td>SGRO</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>299.90</td>
					<td>298.80</td>
					<td>320.00</td>
					<td>320.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/LAND/Land-Securities-Group-Plc-share-price"">Land Securities...</a></td>
					<td>LAND</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>963.00</td>
					<td>972.00</td>
					<td>980.00</td>
					<td>980.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/INTU/Intu-Properties-share-price"">Intu Properties</a></td>
					<td>INTU</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>328.70</td>
					<td>331.30</td>
					<td>410.00</td>
					<td>410.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HMSO/Hammerson-share-price"">Hammerson</a></td>
					<td>HMSO</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>531.00</td>
					<td>540.00</td>
					<td>550.00</td>
					<td>550.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CAPC/Capital-Counties-Properties-PLC-share-price"">Capital &...</a></td>
					<td>CAPC</td>
					<td>Deutsche Bank</td>
					<td>Sell</td>
					<td>355.40</td>
					<td>355.60</td>
					<td>280.00</td>
					<td>280.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/BLND/British-Land-Co-PLC-share-price"">British Land Co PLC</a></td>
					<td>BLND</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>614.50</td>
					<td>617.50</td>
					<td>710.00</td>
					<td>710.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/GPOR/Great-Portland-Estates-PLC-share-price"">Great Portland...</a></td>
					<td>GPOR</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>581.00</td>
					<td>583.00</td>
					<td>650.00</td>
					<td>650.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/DLN/Derwent-London-share-price"">Derwent London</a></td>
					<td>DLN</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>2,495.00</td>
					<td>2,495.00</td>
					<td>2,760.00</td>
					<td>2,760.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CRH/CRH-PLC-share-price"">CRH PLC</a></td>
					<td>CRH</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>1,345.00</td>
					<td>1,336.00</td>
					<td>1,520.00</td>
					<td>1,580.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/VOD/Vodafone-Group-PLC-share-price"">Vodafone Group PLC</a></td>
					<td>VOD</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>193.80</td>
					<td>191.55</td>
					<td>217.00</td>
					<td>217.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HAS/Hays-PLC-share-price"">Hays PLC</a></td>
					<td>HAS</td>
					<td>Deutsche Bank</td>
					<td>Hold</td>
					<td>100.70</td>
					<td>99.90</td>
					<td>-</td>
					<td>86.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PMO/Premier-Oil-PLC-share-price"">Premier Oil PLC</a></td>
					<td>PMO</td>
					<td>Deutsche Bank</td>
					<td>Buy</td>
					<td>362.60</td>
					<td>358.30</td>
					<td>560.00</td>
					<td>566.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/PMO/Premier-Oil-PLC-share-price"">Premier Oil PLC</a></td>
					<td>PMO</td>
					<td>Liberum Capital</td>
					<td>Sell</td>
					<td>362.60</td>
					<td>358.30</td>
					<td>313.00</td>
					<td>313.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/VRS/Versarien-PLC-share-price"">Versarien PLC</a></td>
					<td>VRS</td>
					<td>Westhouse Securities</td>
					<td>Buy</td>
					<td>13.00</td>
					<td>13.00</td>
					<td>-</td>
					<td>20.00</td>
					<td>Initiates/Starts</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/HAS/Hays-PLC-share-price"">Hays PLC</a></td>
					<td>HAS</td>
					<td>Credit Suisse</td>
					<td>Outperform</td>
					<td>100.70</td>
					<td>99.90</td>
					<td>99.00</td>
					<td>110.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/GSK/GlaxoSmithKline-PLC-share-price"">GlaxoSmithKline PLC</a></td>
					<td>GSK</td>
					<td>Jefferies International</td>
					<td>Hold</td>
					<td>1,749.00</td>
					<td>1,742.50</td>
					<td>-</td>
					<td>1,800.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/DGE/Diageo-PLC-share-price"">Diageo PLC</a></td>
					<td>DGE</td>
					<td>Jefferies International</td>
					<td>Buy</td>
					<td>1,999.50</td>
					<td>2,019.00</td>
					<td>2,300.00</td>
					<td>2,300.00</td>
					<td>Retains</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/CRDA/Croda-International-PLC-share-price"">Croda...</a></td>
					<td>CRDA</td>
					<td>Jefferies International</td>
					<td>Hold</td>
					<td>2,601.00</td>
					<td>2,600.00</td>
					<td>2,600.00</td>
					<td>2,600.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/SAB/SABMiller-PLC-share-price"">SABMiller PLC</a></td>
					<td>SAB</td>
					<td>Jefferies International</td>
					<td>Buy</td>
					<td>3,249.50</td>
					<td>3,263.50</td>
					<td>3,200.00</td>
					<td>3,680.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/AZN/AstraZeneca-PLC-share-price"">AstraZeneca PLC</a></td>
					<td>AZN</td>
					<td>Jefferies International</td>
					<td>Hold</td>
					<td>3,267.00</td>
					<td>3,250.00</td>
					<td>3,560.00</td>
					<td>3,400.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ASHM/Ashmore-Group-PLC-share-price"">Ashmore Group PLC</a></td>
					<td>ASHM</td>
					<td>Barclays Capital</td>
					<td>Equal weight</td>
					<td>371.45</td>
					<td>376.70</td>
					<td>-</td>
					<td>410.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ABF/Associated-British-Foods-PLC-share-price"">Associated...</a></td>
					<td>ABF</td>
					<td>Barclays Capital</td>
					<td>Overweight</td>
					<td>1,879.00</td>
					<td>1,907.00</td>
					<td>-</td>
					<td>-</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/MKS/Marks-Spencer-Group-PLC-share-price"">Marks & Spencer...</a></td>
					<td>MKS</td>
					<td>Barclays Capital</td>
					<td>Underweight</td>
					<td>466.10</td>
					<td>463.90</td>
					<td>350.00</td>
					<td>350.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/RB./Reckitt-Benckiser-Group-PLC-share-price"">Reckitt Benckiser...</a></td>
					<td>RB.</td>
					<td>Bank of America Merrill Lynch</td>
					<td>Buy</td>
					<td>4,677.00</td>
					<td>4,929.00</td>
					<td>5,250.00</td>
					<td>5,250.00</td>
					<td>Retains</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ABF/Associated-British-Foods-PLC-share-price"">Associated...</a></td>
					<td>ABF</td>
					<td>Bank of America Merrill Lynch</td>
					<td>Neutral</td>
					<td>1,879.00</td>
					<td>1,907.00</td>
					<td>2,150.00</td>
					<td>2,150.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class=""alt"">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/KGI/Kirkland-Lake-Gold-Inc-share-price"">Kirkland Lake...</a></td>
					<td>KGI</td>
					<td>Investec</td>
					<td>Buy</td>
					<td>244.00</td>
					<td>265.00</td>
					<td>396.00</td>
					<td>380.00</td>
					<td>Reiterates</td>
				</tr>
								<tr class="""">
					<td class=""center"">12 Jul 2013</td>
					<td><a href=""/quote/ASHM/Ashmore-Group-PLC-share-price"">Ashmore Group PLC</a></td>
					<td>ASHM</td>
					<td>Morgan Stanley</td>
					<td>Equal weight</td>
					<td>371.45</td>
					<td>376.70</td>
					<td>444.00</td>
					<td>420.00</td>
					<td>Reiterates</td>
				</tr>
							</tbody>
		</table>
	</div>

		<p class=""right bot15""><a class=""arrow"" href=""/broker-views/index/date/11-07-2013"">previous day<span></span></a></p>
	
	<div class=""moneyam-footer bot20"">
	<a class=""mam-corpsolutions"" href=""http://www.moneyam.com/corpsolutions/"">MoneyAM Corporate Solutions</a>
	<p>The share data supplied on this page is provided by MoneyAM Corporate Solutions and incorporates share prices, market news, indices, charts, fundamentals, heatmaps, stock screeners and investor research tools. MoneyAM Terms &amp; Conditions.</p>
</div></div>
<script type=""text/javascript"">
	$j(function() {
		$j(""#broker-views-table"").tablesorter({
			sortList: false,
			widgets: ['zebra'],
			headers: {
				0: { sorter: false },
				5: { sorter: 'fancyNumber'},
				6: { sorter: 'fancyNumber'},
				7: { sorter: 'fancyNumber'},
				8: { sorter: 'fancyNumber'}
			}
		});
	});
</script></div>

        <iframe src=""http://www.dailymail.co.uk/ce/item.cms?itemId=1001187&itemType=linkListGroup&versionId=0&styleId=44&ddGroup=3&contenteditor=true&decorator=contenteditor"" width=""964"" height=""190"" frameborder=""0"" scrolling=""no""></iframe>

        <div class=""footer"">
            <div class=""page-header"">
                <div class=""money"">
                    <div class=""nav-secondary wocc link-lccox cleared bdrgr3 no-border"">
                        <ul class=""float-l"">
                            <li class=""first"">
                                <a href=""http://www.thisismoney.co.uk/money/index.html"" class='current'>Money Home</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/markets/index.html"">Markets</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/saving/index.html"">Saving</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/investing/index.html"">Investing</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/bills/index.html"">Bills</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/cars/index.html"">Cars</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/holidays/index.html"">Holidays</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/cardsloans/index.html"">Cards & loans</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/pensions/index.html"">Pensions</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/mortgageshome/index.html"">Mortgages & home</a>
                            </li>
                            <li class="""">
                                <a href=""http://www.thisismoney.co.uk/money/experts/index.html"">Experts</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class=""page-footer tim-footer"">
            <img src=""http://i.dailymail.co.uk/i/furniture/tim/timFooterLogo.png"" alt=""This is Money logo"" width=""175"" height=""28""/>
            <p>This is Money is part of the Daily Mail, The Mail on Sunday &amp; Metro Media Group</p>
            <p>&copy; Associated Newspapers Limited 2011</p>
            <a href=""http://www.thisismoney.co.uk/money/sitemap.html"">Sitemap</a>
            <a rel=""nofollow"" target=""_blank"" href=""http://www.mailconnected.co.uk/"">Advertise with us</a>
			<a href=""http://www.thisismoney.co.uk/money/makemoney"">About us</a>
			<a href=""http://www.thisismoney.co.uk/money/contactus"">Contact us</a>
			<a href=""http://www.thisismoney.co.uk/money/terms"">Terms</a>
            <a href=""http://www.thisismoney.co.uk/money/privacy"" class=""last"">Privacy policy &amp; cookies</a>
        </div>
    </div>
</body>
</html>"
            ;
        }
    }
}