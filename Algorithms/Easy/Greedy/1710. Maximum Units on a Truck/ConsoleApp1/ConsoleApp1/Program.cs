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
            int[][] input = new int[][]
            {
                new int[] { 1, 3 },
                new int[] { 2, 2 },
                new int[] { 3, 1 }
            };

            Console.WriteLine(solution.MaximumUnits(input, 4));


            Console.ReadLine();
        }
    }
}
