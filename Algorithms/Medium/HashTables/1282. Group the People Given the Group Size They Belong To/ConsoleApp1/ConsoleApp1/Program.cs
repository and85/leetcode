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
            solution.GroupThePeople(new int[] { 3, 3, 3, 3, 3, 1, 3 });

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
