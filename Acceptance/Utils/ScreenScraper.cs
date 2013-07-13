namespace Acceptance.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Net;
    using System.IO;

    namespace BusinessLogic
    {
        public class ScreenScraper
        {
            public static string Scrape(string url)
            {
                WebRequest request = WebRequest.Create(url);
                ((HttpWebRequest)request).UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1)";

                string result;

                using (WebResponse httpResponse = request.GetResponse())
                {
                    using (TextReader readStream = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                    {
                        result = readStream.ReadToEnd();
                    }
                }

                return result;
            }
        }
    }

}