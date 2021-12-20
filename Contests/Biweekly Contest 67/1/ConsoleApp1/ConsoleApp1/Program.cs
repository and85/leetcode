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
            solution.MaxSubsequence(new int[] { -1, -2, 3, 4 }, 3);
            Console.ReadLine();
        }
    }
}
