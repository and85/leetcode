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

            var results1 = solution.SuggestedProducts(new string[] { "mobile", "mouse", "moneypot", "monitor", "mousepad" }, "mouse"); 
            foreach (var line in results1)
            {
                Console.WriteLine(string.Join(" ", line));
            }

            Console.ReadLine();
        }
    }
}
