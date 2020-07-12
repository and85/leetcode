using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, -2, -2, -2 };
            var solution = new Solution();
            solution.AsteroidCollision(array);
        }
    }
}
