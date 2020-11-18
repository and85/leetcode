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
            solution.NextGreaterElement(1999999999);

            // Output 14222334
            // Expected 13222344

            Console.ReadLine();
        }
    }
}
