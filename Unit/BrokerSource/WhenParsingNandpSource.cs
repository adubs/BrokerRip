using System;
using System.Collections.Generic;
using Entity;
using Logic.BrokerSource;
using NUnit.Framework;

namespace Unit.BrokerSource
{
    [TestFixture]
    public class WhenParsingNandpSource
    {
        [Test]
        public void ReturnValueShouldBeListOfBrokerRips()
        {
            string pageString = GetPageText();
            var sut = new NandpParser();

            var result = sut.Parse(pageString);

            Assert.That(result, Is.InstanceOf<List<BrokerRip>>());
        }

        [Test]
        public void ShouldReturnAllViews()
        {
            var result = parsePage();

            Assert.That(result.Count, Is.EqualTo(104));
        }

        private List<BrokerRip> parsePage()
        {
            string pageString = GetPageText();
            var sut = new NandpParser();

            var result = sut.Parse(pageString);
            return result;
        }

        [Test]
        public void ShouldParseStockName()
        {
            var result = parsePage();

            Assert.That(result[0].StockName, Is.EqualTo("Petrofac Ltd"));
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
            var increase =Math.Round((1700.00 - 1298.00)/1298 * 100);

            Assert.That(result[0].TargetIncrease, Is.EqualTo(increase));
        }

        private string GetPageText()
        {
            return
                @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional//EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">
<html xmlns=""http://www.w3.org/1999/xhtml"" xml:lang=""en"" lang=""en"">
<head id=""ctl00_ctl00_ctl00_Head1"">
	<title>Broker Views</title>
	<meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
<meta name=""description"" content=""The Broker Views service covers the UK markets and provides up-to-date, comprehensive, aggregated broker recommendations..."" />
	<meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"" />
	<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
	<meta name=""copyright"" content=""Norwich and Peterborough Building Society 2013"" />
    <meta name=""google-site-verification"" content=""TqAp6jAGpgU-BTGAJB7UDTNCkcQaNLfA7bNvmUV6kHQ"" />
	<link href=""http://www.nandp.co.uk/bundles/css/master?v=x02bRXIzEZICdwA3u-N0pfsn2uvkCsKkkXfICBIkB041"" rel=""stylesheet"" media=""screen""/>
	<link href=""http://www.nandp.co.uk/bundles/css/print?v=VUSZQHvKD5X6cI-saXUAMHxSfxjzeAuO7myUT2bq_Jw1"" rel=""stylesheet"" media=""print""/>
    <!--[if IE]>
        <link href=""http://www.nandp.co.uk/css/ie.css"" rel=""stylesheet media=""screen"" />
    <![endif]-->
    <!--[if IE 6]>
        <link href=""http://www.nandp.co.uk/css/ie6.css"" rel=""stylesheet media=""screen"" />
    <![endif]-->
    <!--[if IE 7]>
        <link href=""http://www.nandp.co.uk/css/ie7.css"" rel=""stylesheet media=""screen"" />
    <![endif]-->
    <script src=""http://www.nandp.co.uk/bundles/js/jquery?v=IvljlmxlCiujXudKCpHSH0TxnuH4slQmpum2Ju5M3eo1"" type=""text/javascript""></script>
    <script src=""http://www.nandp.co.uk/bundles/js/main?v=FnOCKgi_hsr8NiMZ_uyCkfNPxAujyVzOkamjraTpnxU1"" type=""text/javascript""></script>	
	<script src=""/js/jquery-1.4.2.min.js"" type=""text/javascript""></script>
	<script src=""/js/jquery.autocomplete.pack.js"" type=""text/javascript""></script>
	<script src=""/flash/amline/swfobject.js"" type=""text/javascript""></script>
	<script src=""/js/jquery.poshytip.js"" type=""text/javascript""></script>
	<meta name=""keywords"" content="""" />
	<meta name=""description"" content="""" />
	
	<link href=""/css/nandp.css?20130618_171221"" rel=""stylesheet"" type=""text/css"" media=""screen, projector, print"" />
	<link href=""/css/poshytip-yellow.css"" rel=""stylesheet"" type=""text/css"" media=""screen"" />
	
</head>

<body id=""www-nandp-co-uk"">
	<div class=""container"">
		<div id=""header"">
            <a id=""skipnav"" href=""#content"">Jump to main content</a>
            <a title=""Return to home page"" href=""http://www.nandp.co.uk""><img id=""ctl00_ctl00_Image1"" src=""http://www.nandp.co.uk/images/logo2.v1304171352.gif"" alt=""Return to Homepage"" style=""border-width:0px;""></a>
            <span class=""pushed"">
                <a accesskey=""0"" href=""http://www.nandp.co.uk"">Key0</a>
                <a accesskey=""1"" href=""http://www.nandp.co.uk/mortgages"">Key1</a>
                <a accesskey=""2"" href=""http://www.nandp.co.uk/savings"">Key2</a>
                <a accesskey=""3"" href=""http://www.nandp.co.uk/current-account"">Key3</a>
                <a accesskey=""4"" href=""http://www.nandp.co.uk/insurance"">Key4</a>
                <a accesskey=""5"" href=""http://www.nandp.co.uk/financial-advice"">Key5</a>
                <a accesskey=""6"" href=""http://www.nandp.co.uk/share-dealing"">Key6</a>
                <a accesskey=""7"" href=""http://www.nandp.co.uk/current-account/credit-card-mbna"">Key7</a>
                <a accesskey=""8"" href=""http://www.nandp.co.uk/contact-us"">Key8</a>
                <a accesskey=""9"" href=""http://www.nandp.co.uk/17901/internet-banking"">Key9</a>
            </span>
            <h2>Norwich and Peterborough Building Society</h2>
            <div id=""related-nav"">
                <div id=""ctl00_ctl00_headerControl_pnlSearchBox"" class=""panelHolder"" onkeypress=""javascript:return WebForm_FireDefaultButton(event, 'ctl00_ctl00_headerControl_btnSearchSubmit')"">
                    <div id=""loginTo"">
                        <h3>Login:</h3>
                        <ul>
                            <li id=""ctl00_ctl00_headerControl_loginToIB"" class=""loginToIB"">
                                <a href=""http://www.nandp.co.uk/17901/internet-banking"" id=""loginToIBLink"" title=""Log into Internet Banking"">Internet Banking</a>
                            </li>
                            <li id=""ctl00_ctl00_headerControl_loginToSD"" class=""loginToSD"">
                                <a href=""http://www.nandp.co.uk/17901/sharedealing-jarvis-login"" id=""loginToSDLink"" title=""Log into Share Dealing"">Share Dealing</a>
                            </li>
                            <li id=""ctl00_ctl00_headerControl_loginToCC"" class=""loginToCC"">
                                <a href=""http://www.nandp.co.uk/17901/Credit-Card-Account-Login"" id=""loginToCCLink"" title=""Log into Credit Card"">Credit Card</a>
                            </li>   
                        </ul>
                    </div>
                </div>
			</div>
			<div id=""nav"">
				<ul>
                    <li><p class=""menu""><a href=""http://www.nandp.co.uk/mortgages/"">Mortgages</a></p></li>
                    <li><p class=""menu""><a href=""http://www.nandp.co.uk/savings/"">Savings</a></p></li>
					<li><p class=""menu""><a href=""http://www.nandp.co.uk/current-account/"">Current account</a></p></li>
                    <li><p class=""menu""><a href=""http://www.nandp.co.uk/insurance/"">Insurance</a></p></li>
                    <li><p class=""menu""><a href=""http://www.nandp.co.uk/financial-advice/"">Financial Advice</a></p></li>
                    <li><p class=""menu""><a class=""menu-share-dealing"" href=""http://sharedealing.nandp.co.uk"">Share dealing</a></p></li>
                </ul>
			</div>
		</div>
		<div id=""breadcrumb"">
			<p>You are here:&nbsp;
				<span id=""ctl00_ctl00_ctl00_MainArea_SiteMapPath2"" DataSourceID=""SiteMapProvider"">
					<a href=""#ctl00_ctl00_ctl00_MainArea_SiteMapPath2_SkipLink""><img alt=""Skip Navigation Links"" height=""0"" width=""0"" src=""http://www.nandp.co.uk/WebResource.axd?d=oOqqBXm-we3n-O8ctOwHUMK7aHwturYLe35aHsq4Bz6IEfU9lyMsdi5Ou38cBd-KtwihWePE9MNmRflTz0M795hCBMc1&amp;t=634383041261406250"" style=""border-width:0px;"" /></a>
					<span><a href=""http://www.nandp.co.uk/"">Home</a></span>
					<span> &gt; </span>
					<span class=""lastBreadcrumb""><a href=""http://sharedealing.nandp.co.uk/"">Share dealing</a></span>
					<a id=""ctl00_ctl00_ctl00_MainArea_SiteMapPath2_SkipLink""></a>
				</span>
			</p>
		</div>
		<div id=""section-nav"">
			<div class=""sideMenuNav"" id=""ctl00_ctl00_ctl00_MainArea_SideMenuNav_sideMenu"" style=""float: left;"">
				<ul class=""level1 static"" tabindex=""0"" role=""menu"" style=""position: relative; width: auto; float: left;"">
					<li role=""menuitem"" class=""static"" style=""position: relative;"">
						<a class=""level1 static"" href=""http://www.nandp.co.uk/share-dealing/buying-and-selling-shares"">Buying and selling shares</a>
					</li>
					<li role=""menuitem"" class=""static"" style=""position: relative;"">
						<a class=""level1 static"" href=""http://www.nandp.co.uk/share-dealing/investment-choices"">Investment choices</a>
					</li>
					<li role=""menuitem"" class=""static"" style=""position: relative;"">
						<a class=""level1 static"" href=""http://www.nandp.co.uk/share-dealing/our-sharedealing-accounts"">Share dealing accounts</a>
					</li>
				</ul>
			</div>
			<h4>Market Information</h4>

<ul id=""optionalNavLinks"">
	<li><a href=""/news/"">Market News</a></li>
	<li><a href=""/charts/"">Charts</a></li>
	<li><a href=""/broker-views/"">Broker views</a></li>
	<li><a href=""/director-deals/"">Director deals</a></li>
	<li><a href=""/diary/"">Forward diary</a></li>
	<li><a href=""/heatmaps/"">Heatmaps</a></li>
	<li><a href=""/companies/"">Company A-Z</a></li>
</ul>			<div class=""teaser last"">
			</div>
			<h4>Useful Information</h4>
			<ul id=""quickLinks"">
				<li><a href=""http://www.nandp.co.uk/PDFs/share-dealing/fees-and-commission-rates"" class=""new-window"">Fees and Commission Rates</a></li>
				<li><a href=""http://www.nandp.co.uk/17901/Make-a-Payment"">Make a payment</a></li>
				<li><a href=""http://www.nandp.co.uk/share-dealing/guide"" class=""new-window"">Guide to Share Dealing</a></li>
				<li><a href=""http://www.nandp.co.uk/share-dealing/Glossary-of-Share-dealing-terms"">Glossary</a></li>
				<li><a href=""http://www.nandp.co.uk/share-dealing/sharedealing-faqs"">FAQ’s</a></li>
				<li><a href=""http://www.nandp.co.uk/share-dealing/transfer-shares"">Transfering Shares</a></li>
				<li><a href=""http://www.nandp.co.uk/share-dealing/useful-forms"">Useful Forms</a></li>
			</ul>
		</div>
		<div id=""banner"">
			
	<div id=""share-price-search"">
		<div id=""epic-search-container"" class=""clearfix"">
			<h3>Company Search</h3>
			<form action=""/quote/"" method=""get"" id=""epic-search-form"">
				<label>Type company name</label>
				<input type=""text"" name=""epic"" value="""" id=""epic-search"" class=""textBoxStyle"" /></label> <input type=""submit"" class=""buttonSubmit"" value=""Go"" />
			</form>

			<script type=""text/javascript"">
				$(function(){
					$(""#epic-search"").autocomplete('/autocomplete/epic/', {
						width: 350, max: 15, scrollHeight: 241, delay: 500, minChars: 2, selectFirst: false,
						formatItem: function(data){
							var res =  data[1] + ' (' + data[0] + ')';
							return res;
						}
						}).result(function(event, data, formatted) {
						$('#epic-search').val(data[0]);
						$('#epic-search-form').submit();
					});
				});
			</script>
		</div>
	</div>
	<div id=""start-trading-links"" class=""wider"">
		<h3>Start Trading</h3>
		<div class=""action clearfix"">
			<span>Existing customers:</span> <a href=""http://www.nandp.co.uk/17901/sharedealing-jarvis-login"">Log in</a>
		</div>
		<div class=""action clearfix"">
			<span>New customers: </span> <a href=""http://www.nandp.co.uk/share-dealing/Sharedealing_Apply_Register"" class=""button loginCreditCard"">Register</a>
		</div>
	</div>
		</div>
		<div id=""content"" class=""category products nav1col underlineElement moneyAMShareDealing"">
			<h1 class=""highlight13"">Broker Views </h1>

<p>The Broker Views service provides comprehensive, aggregated broker recommendations, covering the all the UK markets. It tells you what the brokers are recommending on various companies and is updated constantly during the day.</p>
<table cellpadding=""0"" cellspacing=""0"">
	<thead>
		<tr>
			<th class=""center"">Date</th>
			<th>Company Name</th>
			<th>Broker</th>
			<th>Rec.</th>
			<th>Price</th>
			<th>Old target price</th>
			<th>New target price</th>
			<th>Notes</th>
		</tr>
	</thead>
	<tbody>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/PFC/Petrofac+Ltd-share-price"">Petrofac Ltd</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>1,298.00</td>
			<td>1,700.00</td>
			<td>1,700.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/ASHM/Ashmore+Group+PLC-share-price"">Ashmore Group PLC</a></td>
			<td>RBC Capital Markets</td>
			<td>Sector Performer</td>
			<td>370.70</td>
			<td>440.00</td>
			<td>375.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BVS/Bovis+Homes+Group+PLC-share-price"">Bovis Homes Group...</a></td>
			<td>Prime Markets</td>
			<td>Buy</td>
			<td>842.50</td>
			<td>-</td>
			<td>850.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/WTB/Whitbread+PLC-share-price"">Whitbread PLC</a></td>
			<td>Galvan Research</td>
			<td>Buy</td>
			<td>3,194.50</td>
			<td>3,400.00</td>
			<td>3,400.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/NTG/Northgate+PLC-share-price"">Northgate PLC</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>347.50</td>
			<td>-</td>
			<td>385.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/MAB/Mitchells+%26+Butlers+PLC-share-price"">Mitchells &...</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>401.95</td>
			<td>400.00</td>
			<td>400.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/INTU/Intu+Properties-share-price"">Intu Properties</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>330.70</td>
			<td>-</td>
			<td>409.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/RMV/Rightmove+PLC-share-price"">Rightmove PLC</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>2,298.50</td>
			<td>-</td>
			<td>2,240.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/WTB/Whitbread+PLC-share-price"">Whitbread PLC</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>3,194.50</td>
			<td>-</td>
			<td>3,420.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SBRY/Sainsbury+%28J%29+PLC-share-price"">Sainsbury (J) PLC</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>384.35</td>
			<td>410.00</td>
			<td>410.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/DXNS/Dixons+Retail+PLc-share-price"">Dixons Retail PLc</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>42.03</td>
			<td>-</td>
			<td>46.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/KGF/Kingfisher+PLC-share-price"">Kingfisher PLC</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>377.00</td>
			<td>-</td>
			<td>430.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/CRST/Crest+Nicholson+Holdings+Plc-share-price"">Crest Nicholson...</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>354.45</td>
			<td>-</td>
			<td>370.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HAS/Hays+PLC-share-price"">Hays PLC</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>100.25</td>
			<td>120.00</td>
			<td>120.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BVIC/Britvic+PLC-share-price"">Britvic PLC</a></td>
			<td>Barclays Capital</td>
			<td>Equal weight</td>
			<td>507.75</td>
			<td>-</td>
			<td>540.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/STAN/Standard+Chartered+PLC-share-price"">Standard...</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>1,528.75</td>
			<td>1,750.00</td>
			<td>1,750.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HSBA/HSBC+Holdings+PLC-share-price"">HSBC Holdings PLC</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>722.60</td>
			<td>850.00</td>
			<td>850.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/RBS/Royal+Bank+of+Scotland+Group+%28The%29+PLC-share-price"">Royal Bank of...</a></td>
			<td>Barclays Capital</td>
			<td>Overweight</td>
			<td>307.10</td>
			<td>370.00</td>
			<td>370.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/LLOY/Lloyds+Banking+Group+PLC-share-price"">Lloyds Banking...</a></td>
			<td>Barclays Capital</td>
			<td>Equal weight</td>
			<td>67.21</td>
			<td>65.00</td>
			<td>65.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/TRP/Tower+Resources+PLC-share-price"">Tower Resources PLC</a></td>
			<td>Fox-Davies</td>
			<td>Buy</td>
			<td>1.53</td>
			<td>5.00</td>
			<td>5.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HOIL/Heritage+Oil+Ltd-share-price"">Heritage Oil Ltd</a></td>
			<td>Fox-Davies</td>
			<td>Buy</td>
			<td>160.50</td>
			<td>350.00</td>
			<td>350.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/GEEC/Great+Eastern+Energy+Corporation-share-price"">Great Eastern...</a></td>
			<td>Fox-Davies</td>
			<td>Buy</td>
			<td>235.00</td>
			<td>440.00</td>
			<td>440.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BLVN/BowLeven+PLC-share-price"">BowLeven PLC</a></td>
			<td>Fox-Davies</td>
			<td>Buy</td>
			<td>64.75</td>
			<td>250.00</td>
			<td>250.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AAZ/Anglo+Asian+Mining+PLC-share-price"">Anglo Asian...</a></td>
			<td>SP Angel</td>
			<td>Buy</td>
			<td>31.25</td>
			<td>54.00</td>
			<td>54.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/ESCH/Escher+Group-share-price"">Escher Group</a></td>
			<td>Davy Research </td>
			<td>Outperform</td>
			<td>225.00</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BVS/Bovis+Homes+Group+PLC-share-price"">Bovis Homes Group...</a></td>
			<td>Davy Research </td>
			<td>Underperform</td>
			<td>842.50</td>
			<td>-</td>
			<td>-</td>
			<td>Under Review</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/ABF/Associated+British+Foods+PLC-share-price"">Associated...</a></td>
			<td>Deutsche Bank</td>
			<td>Outperform</td>
			<td>1,881.50</td>
			<td>1,750.00</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/RBS/Royal+Bank+of+Scotland+Group+%28The%29+PLC-share-price"">Royal Bank of...</a></td>
			<td>Investec</td>
			<td>Buy</td>
			<td>307.10</td>
			<td>310.00</td>
			<td>310.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/ZTF/Zotefoams+PLC-share-price"">Zotefoams PLC</a></td>
			<td>Investec</td>
			<td>Buy</td>
			<td>206.00</td>
			<td>240.00</td>
			<td>240.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AIE/Anite+PLC-share-price"">Anite PLC</a></td>
			<td>Investec</td>
			<td>Buy</td>
			<td>131.80</td>
			<td>135.00</td>
			<td>155.00</td>
			<td>Upgrades</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SYR/Synergy+Health+PLC-share-price"">Synergy Health PLC</a></td>
			<td>Investec</td>
			<td>Add</td>
			<td>1,133.00</td>
			<td>1,170.00</td>
			<td>1,170.00</td>
			<td>Downgrades</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/KIE/Kier+Group+PLC-share-price"">Kier Group PLC</a></td>
			<td>Liberum Capital</td>
			<td>Buy</td>
			<td>1,419.00</td>
			<td>1,450.00</td>
			<td>1,450.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/NCC/NCC+Group+PLC-share-price"">NCC Group PLC</a></td>
			<td>Canaccord Genuity</td>
			<td>Buy</td>
			<td>140.38</td>
			<td>175.00</td>
			<td>175.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/IQE/IQE+PLC-share-price"">IQE PLC</a></td>
			<td>Canaccord Genuity</td>
			<td>Buy</td>
			<td>24.38</td>
			<td>65.00</td>
			<td>65.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SNT/Sabien+Technology+Group+PLC-share-price"">Sabien Technology...</a></td>
			<td>Westhouse Securities</td>
			<td>Buy</td>
			<td>26.50</td>
			<td>50.00</td>
			<td>50.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BVS/Bovis+Homes+Group+PLC-share-price"">Bovis Homes Group...</a></td>
			<td>Shore Capital</td>
			<td>Hold</td>
			<td>842.50</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HEAD/Headlam+Group+PLC-share-price"">Headlam Group PLC</a></td>
			<td>Shore Capital</td>
			<td>Hold</td>
			<td>347.88</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HIK/Hikma+Pharmaceuticals+PLC-share-price"">Hikma...</a></td>
			<td>Shore Capital</td>
			<td>Buy</td>
			<td>1,084.00</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HSBA/HSBC+Holdings+PLC-share-price"">HSBC Holdings PLC</a></td>
			<td>Shore Capital</td>
			<td>Buy</td>
			<td>722.60</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/PFL/Premier+Farnell+PLC-share-price"">Premier Farnell PLC</a></td>
			<td>Shore Capital</td>
			<td>Hold</td>
			<td>220.00</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/ECM/Electrocomponents+PLC-share-price"">Electrocomponents...</a></td>
			<td>Shore Capital</td>
			<td>Sell</td>
			<td>252.45</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/STAN/Standard+Chartered+PLC-share-price"">Standard...</a></td>
			<td>Shore Capital</td>
			<td>Buy</td>
			<td>1,528.75</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/LLOY/Lloyds+Banking+Group+PLC-share-price"">Lloyds Banking...</a></td>
			<td>Shore Capital</td>
			<td>Buy</td>
			<td>67.21</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/MML/Medusa+Mining+Ltd-share-price"">Medusa Mining Ltd</a></td>
			<td>SP Angel</td>
			<td>Buy</td>
			<td>102.63</td>
			<td>450.00</td>
			<td>300.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HSP/Hargreaves+Services+PLC-share-price"">Hargreaves...</a></td>
			<td>N+1 Singer</td>
			<td>Corporate</td>
			<td>838.75</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/NVA/Novae+Group+PLC-share-price"">Novae Group PLC</a></td>
			<td>Westhouse Securities</td>
			<td>Neutral</td>
			<td>510.00</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/LRE/Lancashire+Holdings+Ltd-share-price"">Lancashire...</a></td>
			<td>Westhouse Securities</td>
			<td>Add</td>
			<td>804.00</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HSX/Hiscox+Ltd-share-price"">Hiscox Ltd</a></td>
			<td>Westhouse Securities</td>
			<td>Neutral</td>
			<td>601.50</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/CGL/Catlin+Group+Ltd-share-price"">Catlin Group Ltd</a></td>
			<td>Westhouse Securities</td>
			<td>Add</td>
			<td>526.50</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BEZ/Beazley+PLC-share-price"">Beazley PLC</a></td>
			<td>Westhouse Securities</td>
			<td>Neutral</td>
			<td>239.15</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AML/Amlin+PLC-share-price"">Amlin PLC</a></td>
			<td>Westhouse Securities</td>
			<td>Add</td>
			<td>416.60</td>
			<td>-</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SRB/Serabi+Mining+PLC-share-price"">Serabi Mining PLC</a></td>
			<td>Sanlam Securities</td>
			<td>Buy</td>
			<td>5.63</td>
			<td>10.00</td>
			<td>10.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/FDSA/Fidessa+Group+PLC-share-price"">Fidessa Group PLC</a></td>
			<td>Sanlam Securities</td>
			<td>Buy</td>
			<td>2,102.00</td>
			<td>2,000.00</td>
			<td>2,340.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/IRV/Interserve+PLC-share-price"">Interserve PLC</a></td>
			<td>Westhouse Securities</td>
			<td>Add</td>
			<td>511.75</td>
			<td>-</td>
			<td>582.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/ACE/Auhua+Clean+Energy-share-price"">Auhua Clean Energy</a></td>
			<td>Northland Capital</td>
			<td>Buy</td>
			<td>21.00</td>
			<td>50.00</td>
			<td>50.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/VCT/Victrex+PLC-share-price"">Victrex PLC</a></td>
			<td>Citigroup</td>
			<td>Neutral</td>
			<td>1,635.00</td>
			<td>1,550.00</td>
			<td>1,550.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SPT/Spirent+Communications+PLC-share-price"">Spirent...</a></td>
			<td>Goldman Sachs</td>
			<td>Buy</td>
			<td>121.35</td>
			<td>164.00</td>
			<td>160.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/POG/Petropavlovsk+PLC-share-price"">Petropavlovsk PLC</a></td>
			<td>Goldman Sachs</td>
			<td>Sell</td>
			<td>73.75</td>
			<td>106.00</td>
			<td>76.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/POLY/Polymetal+International+PLC-share-price"">Polymetal...</a></td>
			<td>Goldman Sachs</td>
			<td>Sell</td>
			<td>508.00</td>
			<td>800.00</td>
			<td>340.00</td>
			<td>Downgrades</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/PGIL/Polyus+Gold+International-share-price"">Polyus Gold...</a></td>
			<td>Goldman Sachs</td>
			<td>Neutral</td>
			<td>206.63</td>
			<td>230.00</td>
			<td>210.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/RB./Reckitt+Benckiser+Group+PLC-share-price"">Reckitt Benckiser...</a></td>
			<td>Credit Suisse</td>
			<td>Neutral</td>
			<td>4,701.00</td>
			<td>4,900.00</td>
			<td>4,900.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AAL/Anglo+American+PLC-share-price"">Anglo American PLC</a></td>
			<td>Credit Suisse</td>
			<td>Neutral</td>
			<td>1,298.00</td>
			<td>-</td>
			<td>1,600.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/PRW/Promethean+World+PLC+-share-price"">Promethean World...</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Neutral</td>
			<td>13.75</td>
			<td>22.00</td>
			<td>-</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/DSC/Development+Securities+PLC-share-price"">Development...</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Neutral</td>
			<td>200.25</td>
			<td>180.00</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AFR/Afren+PLC-share-price"">Afren PLC</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Neutral</td>
			<td>137.40</td>
			<td>-</td>
			<td>-</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/MARS/Marston%27s+PLC-share-price"">Marston's PLC</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Overweight</td>
			<td>151.75</td>
			<td>170.00</td>
			<td>170.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/MAB/Mitchells+%26+Butlers+PLC-share-price"">Mitchells &...</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Neutral</td>
			<td>401.95</td>
			<td>390.00</td>
			<td>390.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/JDW/Wetherspoon+%28J+D%29+PLC-share-price"">Wetherspoon (J D)...</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Underweight</td>
			<td>669.00</td>
			<td>520.00</td>
			<td>520.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/GNK/Greene+King+PLC-share-price"">Greene King PLC</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Overweight</td>
			<td>852.50</td>
			<td>880.00</td>
			<td>880.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/YNGA/Young+%26+Co%27s+Brewery+PLC-share-price"">Young & Co's...</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Overweight</td>
			<td>885.25</td>
			<td>840.00</td>
			<td>910.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/RTN/Restaurant+Group+%28The%29+PLC-share-price"">Restaurant Group...</a></td>
			<td>JP Morgan Cazenove</td>
			<td>Overweight</td>
			<td>549.50</td>
			<td>525.00</td>
			<td>565.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SMIN/Smiths+Group+PLC-share-price"">Smiths Group PLC</a></td>
			<td>HSBC</td>
			<td>Overweight</td>
			<td>1,380.00</td>
			<td>1,550.00</td>
			<td>1,550.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/HIK/Hikma+Pharmaceuticals+PLC-share-price"">Hikma...</a></td>
			<td>HSBC</td>
			<td>Neutral</td>
			<td>1,084.00</td>
			<td>745.00</td>
			<td>1,035.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/POLY/Polymetal+International+PLC-share-price"">Polymetal...</a></td>
			<td>HSBC</td>
			<td>Overweight</td>
			<td>508.00</td>
			<td>1,000.00</td>
			<td>620.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/VOD/Vodafone+Group+PLC-share-price"">Vodafone Group PLC</a></td>
			<td>Credit Suisse</td>
			<td>Outperform</td>
			<td>194.63</td>
			<td>-</td>
			<td>195.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/RDSA/Royal+Dutch+Shell+PLC-share-price"">Royal Dutch Shell...</a></td>
			<td>Exane BNP Paribas</td>
			<td>Neutral</td>
			<td>2,214.75</td>
			<td>2,350.00</td>
			<td>2,350.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BP./BP+PLC-share-price"">BP PLC</a></td>
			<td>Exane BNP Paribas</td>
			<td>Outperform</td>
			<td>464.90</td>
			<td>575.00</td>
			<td>575.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BG./BG+Group+PLC-share-price"">BG Group PLC</a></td>
			<td>Exane BNP Paribas</td>
			<td>Outperform</td>
			<td>1,180.75</td>
			<td>1,470.00</td>
			<td>1,470.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SIG/Signet+Jewelers+Ltd-share-price"">Signet Jewelers Ltd</a></td>
			<td>Exane BNP Paribas</td>
			<td>Outperform</td>
			<td>4,734.50</td>
			<td>5,300.00</td>
			<td>5,300.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AAL/Anglo+American+PLC-share-price"">Anglo American PLC</a></td>
			<td>Exane BNP Paribas</td>
			<td>Underperform</td>
			<td>1,298.00</td>
			<td>1,700.00</td>
			<td>1,400.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SHP/Shire+PLC-share-price"">Shire PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Buy</td>
			<td>2,240.00</td>
			<td>2,390.00</td>
			<td>2,390.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BTG/BTG+PLC-share-price"">BTG PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Buy</td>
			<td>396.30</td>
			<td>475.00</td>
			<td>475.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/GSK/GlaxoSmithKline+PLC-share-price"">GlaxoSmithKline PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Buy</td>
			<td>1,748.00</td>
			<td>1,960.00</td>
			<td>1,960.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AZN/AstraZeneca+PLC-share-price"">AstraZeneca PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Hold</td>
			<td>3,262.50</td>
			<td>3,550.00</td>
			<td>3,550.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/NG./National+Grid+PLC-share-price"">National Grid PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Sell</td>
			<td>760.25</td>
			<td>660.00</td>
			<td>660.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/DRX/Drax+Group+PLC-share-price"">Drax Group PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Buy</td>
			<td>610.75</td>
			<td>700.00</td>
			<td>700.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SSE/SSE+PLC-share-price"">SSE PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Hold</td>
			<td>1,592.50</td>
			<td>1,400.00</td>
			<td>1,400.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/CNA/Centrica+PLC-share-price"">Centrica PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Hold</td>
			<td>370.60</td>
			<td>340.00</td>
			<td>340.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BLND/British+Land+Co+PLC-share-price"">British Land Co PLC</a></td>
			<td>Deutsche Bank</td>
			<td>Buy</td>
			<td>615.00</td>
			<td>710.00</td>
			<td>710.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AQP/Aquarius+Platinum+Ltd-share-price"">Aquarius Platinum...</a></td>
			<td>Deutsche Bank</td>
			<td>Buy</td>
			<td>42.13</td>
			<td>55.00</td>
			<td>55.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/VOD/Vodafone+Group+PLC-share-price"">Vodafone Group PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>194.63</td>
			<td>210.00</td>
			<td>210.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SSE/SSE+PLC-share-price"">SSE PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Underweight</td>
			<td>1,592.50</td>
			<td>1,185.00</td>
			<td>1,185.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/NG./National+Grid+PLC-share-price"">National Grid PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>760.25</td>
			<td>880.00</td>
			<td>880.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/ENQ/EnQuest+Plc-share-price"">EnQuest Plc</a></td>
			<td>Morgan Stanley</td>
			<td>Underweight</td>
			<td>126.60</td>
			<td>120.00</td>
			<td>120.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BP./BP+PLC-share-price"">BP PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Underweight</td>
			<td>464.90</td>
			<td>452.00</td>
			<td>452.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AFR/Afren+PLC-share-price"">Afren PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>137.40</td>
			<td>220.00</td>
			<td>220.00</td>
			<td>Retains</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/TLW/Tullow+Oil+PLC-share-price"">Tullow Oil PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>1,100.50</td>
			<td>1,730.00</td>
			<td>1,730.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/WG./John+Wood+Group+PLC-share-price"">John Wood Group PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>899.00</td>
			<td>1,040.00</td>
			<td>1,040.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BG./BG+Group+PLC-share-price"">BG Group PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>1,180.75</td>
			<td>1,400.00</td>
			<td>1,400.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/TCY/Telecity+Group+PLC-share-price"">Telecity Group PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>986.25</td>
			<td>1,200.00</td>
			<td>1,200.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/SGE/Sage+Group+%28The%29+PLC-share-price"">Sage Group (The) PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Equal weight</td>
			<td>366.05</td>
			<td>320.00</td>
			<td>320.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/AVV/AVEVA+Group+PLC-share-price"">AVEVA Group PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>2,494.00</td>
			<td>2,400.00</td>
			<td>2,400.00</td>
			<td>Reiterates</td>
		</tr>
				<tr class="""">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/INVP/Investec+PLC-share-price"">Investec PLC</a></td>
			<td>Morgan Stanley</td>
			<td>Overweight</td>
			<td>433.20</td>
			<td>525.00</td>
			<td>500.00</td>
			<td>Retains</td>
		</tr>
				<tr class=""alt last"">
			<td class=""center date"">08 Jul 13</td>
			<td><a href=""/quote/BBY/Balfour+Beatty+PLC-share-price"">Balfour Beatty PLC</a></td>
			<td>Bank of America Merrill Lynch</td>
			<td>Neutral</td>
			<td>221.60</td>
			<td>255.00</td>
			<td>240.00</td>
			<td>Downgrades</td>
		</tr>
			</tbody>
</table>
	
<p class=""right bot15""><a class=""arrow"" href=""/broker-views/index/date/07-07-2013"">previous day<span></span></a></p>

			<div class=""moneyam-footer"">
				<a class=""mam-corpsolutions"" href=""http://www.moneyam.com/corpsolutions/"">MoneyAM Corporate Solutions</a>
				<p>The share data supplied on this page is provided by MoneyAM Corporate Solutions and incorporates share prices, market news, indices, charts, fundamentals, heatmaps, stock screeners and investor research tools. N&P accepts no responsibility for the content of this page.</p>
			</div>
			<hr />
			<div class=""advisoryText clear-left"">
				<div class=""formattedTextArea"">
					Please remember that stocks and shares and any income derived from them can rise and fall in value.<br />
					You may not get back the full amount of your investment.<br />
					If in doubt please consult an independent investment adviser. 
				</div>
			</div>
		</div>
		<div id=""footer"">
            <ul>
                <li class=""firstMenuItem""><a href=""http://www.nandp.co.uk/about-us"" id=""ctl00_ctl00_menuitem1"">About us</a></li>
				<li><a href=""http://www.nandp.co.uk/jobs"" id=""ctl00_ctl00_menuitem2"">Jobs at N&amp;P</a></li>
				<li><a href=""http://gibraltar.nandp.co.uk"" id=""ctl00_ctl00_menuitem3"">Gibraltar</a></li>
				<li><a href=""http://www.nandp.co.uk/legal/"" id=""ctl00_ctl00_menuitem4"">Legal</a></li>
				<li><a href=""http://www.nandp.co.uk/security"" id=""ctl00_ctl00_menuitem5"">Security</a></li>
				<li><a href=""http://www.nandp.co.uk/privacy-and-cookies"" id=""ctl00_ctl00_menuitem6"">Privacy &amp; Cookies</a></li>
				<li><a href=""http://www.nandp.co.uk/accessibility"" id=""ctl00_ctl00_menuitem7"">Accessibility</a></li>
				<li><a href=""http://www.nandp.co.uk/sitemap"" id=""ctl00_ctl00_menuitem8"">Site map</a></li>                        
				<li id=""ctl00_ctl00_menuitem9"" class=""lastMenuItem""><a href=""http://www.ybs.co.uk"">Yorkshire Building Society</a></li>
            </ul>
			<p>
				NORWICH &amp; PETERBOROUGH BUILDING SOCIETY SHARE DEALING SERVICE IS PROVIDED BY JARVIS INVESTMENT MANAGEMENT LTD (JARVIS), AND JARVIS IS ENTIRELY RESPONSIBLE FOR THE PERFORMANCE OF THE SERVICES. JARVIS INVESTMENT MANAGEMENT LTD IS AUTHORISED AND REGULATED BY THE FINANCIAL CONDUCT AUTHORITY. JARVIS IS A MEMBER OF THE LONDON STOCK EXCHANGE AND ISDX MARKETS, AND AN APPROVED HM REVENUE &amp; CUSTOMS ISA MANAGER.
			</p>
			<p lang=""EN"">
				Norwich &amp; Peterborough Building Society and N&amp;P are trading names of Yorkshire Building Society. Yorkshire Building Society is a member of the Building Societies Association and is authorised by the Prudential Regulation Authority and regulated by the Financial Conduct Authority and the Prudential Regulation Authority. Yorkshire Building Society is entered in the Financial Services Register and its registration number is 106085. Principal office of Yorkshire Building Society: Yorkshire House, Yorkshire Drive, Bradford, BD5 8LJ.
			</p>
			<p lang=""EN"">
				All communications with us may be monitored/recorded to improve the quality of our service and for your protection and security. Landline calls to 0800 numbers are free. Mobile phone providers may charge. Charges to 0845 numbers may vary. Prices can be checked with your phone provider. Mobile calls usually cost more.
			</p>
		</div>
	</div>
	<div id=""ctl00_ctl00_ctl00_Tracking_PanelSiteStat"">
		<script type=""text/javascript"">
			<!--
			function sitestat(ns_l) {
				ns_l += '&amp;ns__t=' + (new Date()).getTime(); ns_pixelUrl = ns_l;
				ns_0 = document.referrer;
				ns_0 = (ns_0.lastIndexOf('/') == ns_0.length - 1) ? ns_0.substring(ns_0.lastIndexOf('/'), 0) : ns_0;
				if (ns_0.length > 0) ns_l += '&amp;ns_referrer=' + escape(ns_0);
				if (document.images) { ns_1 = new Image(); ns_1.src = ns_l; } else
					document.write('<img src=""' + ns_l + '"" width=""1"" height=""1"" alt="""">');
			}
			sitestat(""http://uk.sitestat.com/npbs/npbs/s?Share-dealing"");
			//-->
		</script>
		<noscript>
			<img id=""ctl00_ctl00_ctl00_Tracking_ImageSiteStat"" alt="""" src=""http://uk.sitestat.com/npbs/npbs/s?Share-dealing"" style=""height:1px;width:1px;border-width:0px;"" />
		</noscript>
	</div>
	<div id=""ctl00_ctl00_Tracking_PanelGoogle"">
		<script type=""text/javascript"">
			var _gaq = _gaq || [];
			_gaq.push(['_setAccount', 'UA-3415732-1']);
			_gaq.push(['_trackPageview']);
			(function () {
				var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;
				ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
				var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);
			})();
		</script>
	</div>
    <div id=""ctl00_ctl00_Tracking_SiteCatalyst"">
        <!-- SiteCatalyst code version: H.25.3. Copyright 1996-2013 Adobe, Inc. All Rights Reserved More info available at http://www.omniture.com -->
        <script language=""JavaScript"" type=""text/javascript"" src=""http://www.nandp.co.uk/javascript/s_code.js""></script>
        <script language=""JavaScript"" type=""text/javascript"">
            <!--
                /* You may give each page an identifying name, server, and channel on the next lines. */
                s.pageName = """"
                s.server = """"
                s.channel = """"
                s.pageType = """"
                s.prop1 = """"
                s.prop2 = """"
                s.prop3 = """"
                s.prop4 = """"
                s.prop5 = """"
                /* Conversion Variables */
                s.campaign = """"
                s.state = """"
                s.zip = """"
                s.events = """"
                s.products = """"
                s.purchaseID = """"
                s.eVar1 = """"
                s.eVar2 = """"
                s.eVar3 = """"
                s.eVar4 = """"
                s.eVar5 = """"
                /************* DO NOT ALTER ANYTHING BELOW THIS LINE ! **************/
                var s_code = s.t(); if (s_code) document.write(s_code)
            //-->
        </script>
            <script language=""JavaScript"" type=""text/javascript"">
            <!--
                if (navigator.appVersion.indexOf('MSIE') >= 0) document.write(unescape('%3C') + '\!-' + '-');
            //-->
        </script>
        <noscript>
            <img src=""http://ybs.112.2o7.net/b/ss/ybsnandp/1/H.25.3--NS/0?[AQB]&amp;cdp=3&amp;[AQE]"" height=""1"" width=""1"" border=""0"" alt="""" />
        </noscript>
        <!--/DO NOT REMOVE/-->
        <!-- End SiteCatalyst code version: H.25.3. -->
    </div>
</body>
</html>";
        }
    }
}