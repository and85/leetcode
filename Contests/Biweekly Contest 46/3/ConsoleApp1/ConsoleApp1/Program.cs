using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var isWater = new int[][]
            {
                new int[] { 0, 1},
                new int[] { 0, 0},
            };

            var s = new Solution();
            s.HighestPeak(isWater);
        }
    }
}
