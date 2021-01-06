using System;
using System.Collections.Generic;
using System.Globalization;
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
            
            solution.FindMinDifference(new List<string>() { "05:31", "22:08", "00:35" });
            Console.ReadLine();
        }
    }
}
