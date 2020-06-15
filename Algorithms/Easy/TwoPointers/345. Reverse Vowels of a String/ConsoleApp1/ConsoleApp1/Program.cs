using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            string actual = solution.ReverseVowels("hello");
            Console.WriteLine(actual);

        }
    }
}
