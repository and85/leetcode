using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.CanJump(new int[] { 2, 3, 1, 1, 4 }));
            Console.WriteLine(solution.CanJump(new int[] { 3, 2, 1, 0, 4 }));
            Console.WriteLine(solution.CanJump(new int[] { 2, 0 }));
            Console.WriteLine(solution.CanJump(new int[] { 1, 3, 2 }));
            Console.ReadLine();
        }
    }
}
