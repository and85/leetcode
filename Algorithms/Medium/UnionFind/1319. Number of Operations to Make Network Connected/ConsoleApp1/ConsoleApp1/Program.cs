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

            int[][] connections = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 3, 4 },
                new int[] { 2, 3 }
            };

            s.MakeConnected(6, connections);

            Console.ReadLine();
        }
    }
}
