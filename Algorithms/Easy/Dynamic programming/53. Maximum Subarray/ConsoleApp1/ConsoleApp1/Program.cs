using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            Console.WriteLine("end");
            Console.ReadLine();        
        }
    }
}
