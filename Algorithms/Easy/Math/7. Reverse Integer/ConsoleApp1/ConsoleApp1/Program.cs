using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            s.Reverse(123);
            s.Reverse(-123);
            s.Reverse(-1);

            Console.WriteLine();
        }
    }
}
