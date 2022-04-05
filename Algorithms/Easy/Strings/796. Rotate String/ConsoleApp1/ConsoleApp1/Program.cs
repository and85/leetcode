using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var solution = new Solution();
            Console.WriteLine(solution.RotateString("abcde", "cdeab"));
            Console.WriteLine(solution.RotateString("abcde", "abced"));            
            Console.WriteLine(solution.RotateString("kifcqeiqoh", "ayyrddojpq"));
            Console.WriteLine(solution.RotateString("bbbacddceeb", "ceebbbbacdd"));
            Console.WriteLine(solution.RotateString("ckahkzpikz", "hkzpikzcka"));
            Console.WriteLine(solution.RotateString("clrwmpkwru", "wmpkwruclr"));

            Console.ReadLine();
        }
    }
}
