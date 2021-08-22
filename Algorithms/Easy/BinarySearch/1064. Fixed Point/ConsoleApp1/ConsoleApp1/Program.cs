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
            solution.FixedPoint(new int[] { -10, -5, 0, 3, 7 });

            Console.ReadLine();
        }
    }
}
