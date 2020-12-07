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
            solution.BuildTree(
                new int[] { 8, 4, 9, 2, 10, 5, 11, 1, 12, 6, 13, 3, 14, 7, 15 },
                new int[] { 8, 9, 4, 10, 11, 5, 2, 12, 13, 6, 14, 15, 7, 3, 1 });

            solution.BuildTree(
                new int[] { 9, 3, 15, 20, 7 }, 
                new int[] { 9, 15, 7, 20, 3 });

            Console.ReadLine();
        }
    }
}
