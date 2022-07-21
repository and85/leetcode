using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            foreach (var r in s.PermuteUnique(new int[] { 1, 1, 2 }))
            {
                Console.WriteLine(string.Join(" ", r));
            }
            Console.WriteLine("-------------------------------------");

            Console.ReadKey();
        }
    }
}
