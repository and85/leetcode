﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int[] coins = { 2};
            solution.CoinChange(coins, 3);

            Console.ReadLine();
        }
    }
}
