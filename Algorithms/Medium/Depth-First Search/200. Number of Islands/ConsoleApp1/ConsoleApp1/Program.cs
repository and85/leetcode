using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new char[][]
            {
                new char[] { '1', '1', '0', '0', '0'},
                new char[] { '1', '1', '0', '0', '0'},
                new char[] { '0',  '0', '1', '0', '0'},
                new char[] { '0',  '0', '0', '1', '1'}
            };


            var solution = new Solution_Attempt1();

            // act
            int actual = solution.NumIslands(grid);


            Console.ReadLine();
        }
    }
}
