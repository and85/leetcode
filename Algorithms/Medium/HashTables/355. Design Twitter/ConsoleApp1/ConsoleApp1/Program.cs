using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Twitter obj = new Twitter();
            //obj.PostTweet(1, 1);
            //obj.GetNewsFeed(1);
            //obj.Follow(2, 1);
            //obj.GetNewsFeed(2);
            //obj.Unfollow(2, 1);
            //obj.GetNewsFeed(2);

            Twitter obj = new Twitter();
            obj.PostTweet(1, 5);
            obj.PostTweet(1, 3);
            obj.GetNewsFeed(1);

            Console.ReadLine();
        }
    }
}
