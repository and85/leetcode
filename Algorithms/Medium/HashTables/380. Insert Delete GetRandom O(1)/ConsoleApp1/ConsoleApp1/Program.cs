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
            var solution = new RandomizedSet();
            solution.Insert(1);
            solution.Insert(10);
            solution.Insert(20);
            solution.Insert(30);

            var r1 = solution.GetRandom();
            var r2 = solution.GetRandom();
            var r3 = solution.GetRandom();

            Console.ReadLine();
        }
    }
}
