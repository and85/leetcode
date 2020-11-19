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
            var solution = new Solution();
            string result1 = solution.MostCommonWord("a, a, a, a, b,b,b,c, c", new string[] { "a" });
            Console.WriteLine(result1);

            string result2 = solution.MostCommonWord("Bob. hIt, baLl", new string[] { "bob", "hit" });
            Console.WriteLine(result2);

            Console.ReadLine();
        }
    }
}
