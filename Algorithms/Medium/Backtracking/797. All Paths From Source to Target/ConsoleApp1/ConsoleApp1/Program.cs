using System;
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
            //int[][] graph = new int[][]
            //{
            //    new int[] {1, 2 },
            //    new int[] {3 },
            //    new int[] {3 },
            //    new int[] { }
            //};

            //int[][] graph = new int[][]
            //{
            //    new int[] { 4, 3, 1 },
            //    new int[] { 3, 2, 4 },
            //    new int[] { 3 },
            //    new int[] { 4 },
            //    new int[] { }
            //};
            int[][] graph = new int[][]
            {
                new int[] { 4, 3, 1 },
                new int[] { 3, 2, 4 },
                new int[] {  },
                new int[] { 4 },
                new int[] { }
            };

            solution.AllPathsSourceTarget(graph);

            Console.ReadLine();
        }
    }
}
