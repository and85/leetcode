using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            solution.NextPermutation(new int[] { 1, 1, 5 });
            solution.NextPermutation(new int[] { 1, 5, 8, 4, 7, 6, 5, 3, 1});


            Console.ReadLine();
        }
    }
}
