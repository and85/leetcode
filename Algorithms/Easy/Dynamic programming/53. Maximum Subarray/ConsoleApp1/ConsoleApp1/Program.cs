using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int sum = solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            int sum2 = solution.MaxSubArray(new int[] { 1 });
            int sum3 = solution.MaxSubArray(new int[] { -1 });
            int sum4 = solution.MaxSubArray(new int[] { 1, 2, -1, -2, 2, 1, -2, 1, 4, -5, 4 });


            Console.WriteLine("end");
            Console.ReadLine();        
        }
    }
}
