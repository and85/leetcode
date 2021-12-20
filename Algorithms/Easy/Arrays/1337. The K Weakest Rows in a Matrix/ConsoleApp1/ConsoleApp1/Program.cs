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

            int[][] mat = new int[][]
            {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1,1,1,1,0 },
                new int[] { 1,0,0,0,0 },
                new int[] { 1,1,0,0,0 },
                new int[] { 1,1,1,1,1 }
            };
            s.KWeakestRows(mat, 3);


            Console.ReadLine();
        }
    }
}
