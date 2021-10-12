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
            solution.NextGreaterElement(new int[] { 4, 1, 2 }, new int[] { 1, 3, 4, 2 });
            
            Console.ReadLine();
        }
    }
}
