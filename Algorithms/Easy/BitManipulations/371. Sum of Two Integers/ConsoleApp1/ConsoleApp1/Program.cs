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

            int num = int.MinValue;
            for (int i = 0; i < 32; i++)
            {
                Console.WriteLine($"{i}:{solution.GetBit(num, i)}");
            }

            string s = Convert.ToString(num, 2);
            Console.WriteLine(s);
            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
