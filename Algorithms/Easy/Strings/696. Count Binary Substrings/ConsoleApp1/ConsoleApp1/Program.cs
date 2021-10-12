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
            Console.WriteLine(solution.CountBinarySubstrings("00110011"));
            Console.WriteLine(solution.CountBinarySubstrings("10101"));

            Console.ReadLine();
        }
    }
}
