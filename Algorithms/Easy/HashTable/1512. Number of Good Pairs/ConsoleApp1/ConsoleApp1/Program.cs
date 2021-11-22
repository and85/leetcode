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
            int[] nums = new int[] { 1, 2, 3, 1, 1, 3 };
            Console.WriteLine(s.NumIdenticalPairs(nums));
            Console.ReadLine();
        }
    }
}
