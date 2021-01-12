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
            solution.Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);

            Console.ReadLine();
        }
    }
}
