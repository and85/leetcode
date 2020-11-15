using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int[] coins = { 186,419,83,408};
            solution.CoinChange(coins, 6249);

            Console.ReadLine();
        }
    }
}
