using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class HtmlParser
    {
       public List<String> GetUrls(String url) 
        {
            

            return new List<string>();
        }
   }

    class Solution
    {
        private HashSet<string> _visitedLinks = new HashSet<string>();
        private string _startHost;

        public IList<string> Crawl(string startUrl, HtmlParser htmlParser)
        {
            if (_startHost == null)
                _startHost = GetHostName(startUrl);

            if (!_visitedLinks.Contains(startUrl))
                _visitedLinks.Add(startUrl);
            else
                return _visitedLinks.ToList();

            foreach (string url in htmlParser.GetUrls(startUrl))
            {
                string curHost = GetHostName(url);
                if (!_startHost.Equals(curHost))
                    continue;                

                Crawl(url, htmlParser);
            }


            return _visitedLinks.ToList();
        }

        private string GetHostName(string startUrl)
        {
            string name = startUrl.Replace("http://", string.Empty);
            int index = name.IndexOf("/");
            if (index != -1)
                name = name.Substring(0, index);

            return name;
        }
    }
}
