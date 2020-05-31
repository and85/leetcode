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
            int[] nums = new int[] { 4, 4, 4, 4, 1, 1, 1, 2, 2, 3 };
            var solution = new Solution();
            solution.TopKFrequent(nums, 2);

            //int[] nums = new int[] { -1, -1 };
            //var solution = new Solution();
            //solution.TopKFrequent(nums, 1);
        }
    }
}
