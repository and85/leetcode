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
            string res = solution.DefangIPaddr("1.1.1.1");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
