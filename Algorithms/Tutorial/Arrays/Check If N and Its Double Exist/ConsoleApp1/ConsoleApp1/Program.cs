using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2, 0, 10, -19, 4, 6, -8 };

            var solution = new Solution();
            solution.CheckIfExist(arr);
            Console.ReadLine();
        }
    }
}
