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
            Test1();
            Test2();
            Test3();

            Console.ReadLine();
        }

        private static void Test1()
        {
            var solution = new Solution();
            int[] nums = new int[] { 1, 2, 2, 4 };
            var output = solution.FindErrorNums(nums);
            foreach (int o in output)
                Console.WriteLine(o);
        }

        private static void Test2()
        {
            var solution = new Solution();
            int[] nums = new int[] { 1, 1 };
            var output = solution.FindErrorNums(nums);
            foreach (int o in output)
                Console.WriteLine(o);
        }

        private static void Test3()
        {
            var solution = new Solution();
            int[] nums = new int[] { 2, 2 };
            var output = solution.FindErrorNums(nums);
            foreach (int o in output)
                Console.WriteLine(o);
        }
    }
}
