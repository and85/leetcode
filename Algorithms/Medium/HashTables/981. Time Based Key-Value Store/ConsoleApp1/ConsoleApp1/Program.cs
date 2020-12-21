using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();

            Console.ReadLine();
        }

        private static void Test1()
        {
            var map = new TimeMap();
            map.Set("love", "high", 10);
            map.Set("love", "low", 20);

            Console.WriteLine(map.Get("love", 5));
            Console.WriteLine(map.Get("love", 10));
            Console.WriteLine(map.Get("love", 15));
            Console.WriteLine(map.Get("love", 20));
            Console.WriteLine(map.Get("love", 25));
        }

        private static void Test2()
        {
            var map = new TimeMap();
            map.Set("foo", "bar", 1);
            Console.WriteLine(map.Get("foo", 1));
            Console.WriteLine(map.Get("foo", 3));
            map.Set("foo", "bar2", 4);
            Console.WriteLine(map.Get("foo", 4));
            Console.WriteLine(map.Get("foo", 5));
        }
    }
}
