﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5};

            var solution = new Solution();
            int res = solution.Search(nums, 5);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
