using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace AlterMarket.logic
{
    class Mediafire
    {
        public static string GetUrl(HtmlDocument document)
        {
            var div_download = document.DocumentNode.SelectSingleNode("//div[@class='download_link']");
            string url = "";
            if (div_download != null)
            {
                var links = div_download.Descendants("a")
                               .Select(a => a.Attributes["href"].Value)
                               .ToList();

                if (links.Count > 0)
                {
                    url = links[0];
                    Console.WriteLine(links[0]);
                }
                else
                {
                    Console.WriteLine("Something went wrong!");
                }
            }
            return url;
        }
    }
}
