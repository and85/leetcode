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
            var s = new Solution();
            var matrix = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1,1,0 },
                new int[] { 1,0,1 }
            };

            s.FloodFill(matrix, 1, 1 ,2);

            Console.ReadLine();
        }
    }
}
