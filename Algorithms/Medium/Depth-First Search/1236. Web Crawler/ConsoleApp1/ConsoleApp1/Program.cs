using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();


            solution.Crawl("http://news.yahoo.com/news/topics/", new HtmlParser());
            Console.ReadLine();
        }
    }
}
