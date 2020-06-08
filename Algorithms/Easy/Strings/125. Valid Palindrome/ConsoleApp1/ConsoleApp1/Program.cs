using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            bool b = solution.IsPalindrome("A man, a plan, a canal: Panama");
            bool b2 = solution.IsPalindrome("0P");
        }
    }
}
