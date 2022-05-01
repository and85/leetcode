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
            //Console.WriteLine(solution.MyPow(2, 4));
            //Console.WriteLine(solution.MyPow(2, -2));
            //Console.WriteLine(solution.MyPow(2, -4));
            //Console.WriteLine(solution.MyPow(3, 3));
            //Console.WriteLine(solution.MyPow(2, 5));
            //Console.WriteLine(solution.MyPow(2, 6));

            Console.WriteLine(solution.MyPow(1, -2147483648));

            //Console.WriteLine(solution.MyPow(53, 1));
            //Console.WriteLine(solution.MyPow(53, 54));
            //Console.WriteLine(solution.MyPow(2.00000, -2147483648));


            Console.ReadLine();
        }
    }
}
