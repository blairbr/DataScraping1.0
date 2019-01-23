using System;
using System.Linq;

namespace ScrapingTest
{
	class Program
	{
		static void Main(string[] args)
		{
			HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
			HtmlAgilityPack.HtmlDocument doc = web.Load("https://www.yellowpages.com/search?search_terms=Software&geo_location_terms=Sydney2C+ND");
			var HeaderNames = doc.DocumentNode.SelectNodes("//a[@class='business-name']").ToList();

		Console.WriteLine(HeaderNames);
			foreach (var item in HeaderNames)
			{
				Console.WriteLine(item.InnerText);
			}

			Console.ReadLine();
		}
	}
}
