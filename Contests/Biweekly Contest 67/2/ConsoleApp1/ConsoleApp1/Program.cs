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
            var r1 = solution.GoodDaysToRobBank(new int[] { 5, 3, 3, 3, 5, 6, 2 }, 2 );
            var r2 = solution.GoodDaysToRobBank(new int[] { 1, 1, 1, 1, 1 }, 0);
            var r3 = solution.GoodDaysToRobBank(new int[] { 1, 2, 3, 4, 5, 6 }, 2);
            var r4 = solution.GoodDaysToRobBank(new int[] { 1 }, 5);
            var r5 = solution.GoodDaysToRobBank(new int[] { 0, 0, 0, 0, 0 }, 3);


            var rr = solution.GoodDaysToRobBank(new int[] { 4, 3, 2, 1 }, 1);

            Console.ReadLine();
        }
    }
}
