﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[][] grid = new int[][]
            {
                new int[] { 1, 1, 0},
                new int[] { 1, 1, 0},
                new int[] { 0, 0, 1}
            };
            var count = solution.FindCircleNum(grid);
            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
