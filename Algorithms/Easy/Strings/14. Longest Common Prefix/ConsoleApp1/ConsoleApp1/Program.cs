using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            string[] array = new string[] { "flower", "flow", "flight" };
            solution.LongestCommonPrefix(array);
        }
    }
}
