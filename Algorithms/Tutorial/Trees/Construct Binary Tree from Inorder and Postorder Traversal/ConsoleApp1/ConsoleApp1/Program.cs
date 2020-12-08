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
            var r1 = solution.BuildTree(
                new int[] { 8, 4, 9, 2, 10, 5, 11, 1, 12, 6, 13, 3, 14, 7, 15 },
                new int[] { 8, 9, 4, 10, 11, 5, 2, 12, 13, 6, 14, 15, 7, 3, 1 });

            var r2 = solution.BuildTree(
                new int[] { 9, 3, 15, 20, 7 }, 
                new int[] { 9, 15, 7, 20, 3 });

            var r3 = solution.BuildTree(
                new int[] { 3, 2, 1 },
                new int[] { 3, 2, 1 });


            var r4 = solution.BuildTree(
                new int[] { 2, 3, 1 },
                new int[] { 3, 2, 1 });

            var r5 = solution.BuildTree(
                 new int[] { },
                 new int[] { });

            Console.ReadLine();
        }
    }
}
