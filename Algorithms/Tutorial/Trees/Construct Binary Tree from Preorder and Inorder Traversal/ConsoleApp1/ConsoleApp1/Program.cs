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

            /*
                      1
                 /        \
                2           3
               / \        /    \
              4    5     6       7
             / \  / \   / \    /  \
            8   9 10 11 12 13  14 15
            */
            var solution = new Solution();
            var r1 = solution.BuildTree(
                new int[] { 1, 2, 4, 8, 9, 5, 10, 11, 3, 6, 12, 13, 7, 14, 15 },
                new int[] { 8, 4, 9, 2, 10, 5, 11, 1, 12, 6, 13, 3, 14, 7, 15 }
                );

            var r2 = solution.BuildTree(
                new int[] { 3, 9, 20, 15, 7 },
                new int[] { 9, 3, 15, 20, 7 });

            Console.ReadLine();
        }
    }
}
