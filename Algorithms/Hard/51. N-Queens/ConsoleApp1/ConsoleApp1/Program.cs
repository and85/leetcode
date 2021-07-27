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
            
            foreach (var solution in s.SolveNQueens(4))
            {
                Console.WriteLine("Solution:");
                foreach (var l in solution)
                    Console.WriteLine(l);
            }

            Console.ReadLine();
        }
    }
}
