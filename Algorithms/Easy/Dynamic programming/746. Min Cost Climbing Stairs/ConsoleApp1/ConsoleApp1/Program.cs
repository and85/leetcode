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

            var r1 = solution.MinCostClimbingStairs(new int[] { 10, 15, 20});
            var r2 = solution.MinCostClimbingStairs(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });
            var r3 = solution.MinCostClimbingStairs(new int[] { 1, 0, 2, 2 });
            Console.ReadLine();
        }
    }
}
