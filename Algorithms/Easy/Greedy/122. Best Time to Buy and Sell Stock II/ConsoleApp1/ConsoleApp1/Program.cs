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
            int actual = solution.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });

            Console.WriteLine(actual);
            Console.ReadLine();
        }
    }
}
