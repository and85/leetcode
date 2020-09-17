using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.IsPalindrome(123454321));
            Console.WriteLine(solution.IsPalindrome(123));

            Console.ReadLine();
        }
    }
}
