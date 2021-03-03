using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.PeakIndexInMountainArray(new int[] { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 3 });
            solution.PeakIndexInMountainArray(new int[] { 3, 5, 3, 2, 0 } );

            Console.ReadLine();
        }
    }
}
