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
            int[] rec1 = new int[] { -1, 0, 1, 1 };
            int[] rec2 = new int[] { 0, -1, 0, 1 };

            var solution = new Solution();
            Console.WriteLine(solution.IsRectangleOverlap(rec1, rec2));

            Console.ReadLine();
        }
    }
}
