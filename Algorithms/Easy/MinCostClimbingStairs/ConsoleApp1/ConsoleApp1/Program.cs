using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            //int cost1 = solution.MinCostClimbingStairs(new int[] { 0, 1, 1, 1});
            //int cost2 = solution.MinCostClimbingStairs(new int[] { 0, 2, 2, 1 });
            //int cost3 = solution.MinCostClimbingStairs(new int[] { 0, 1, 2, 2 });
            int cost4 = solution.MinCostClimbingStairs(new int[] { 1, 2, 3, 4, 5 });

            Console.ReadLine();
        }
    }
}
