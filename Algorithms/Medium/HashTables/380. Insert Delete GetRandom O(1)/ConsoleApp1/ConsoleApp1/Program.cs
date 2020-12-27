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
            solution.Insert(2);
            solution.Insert(3);
            solution.Insert(4);
            solution.Insert(5);

            solution.Remove(2);

            var r = solution.GetRandom();

            Console.ReadLine();
        }
    }
}
