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
            Case1();
            Case2();

            Console.ReadLine();
        }

        private static void Case1()
        {
            var solution = new Solution();

            var wall = new List<IList<int>>()
            {
                new List<int>() { 1, 2, 2, 1 },
                new List<int>() { 3,1,2 },
                new List<int>() { 1,3,2 },
                new List<int>() { 2,4 },
                new List<int>() { 3,1,2 },
                new List<int>() { 1,3,1,1 }
            };
            solution.LeastBricks(wall);
        }

        private static void Case2()
        {
            var solution = new Solution();

            var wall = new List<IList<int>>()
            {
                new List<int>() { 1 },
                new List<int>() { 1 },
                new List<int>() { 1 }
            };
            solution.LeastBricks(wall);
        }
    }
}
