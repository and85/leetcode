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
            var actual1 = solution.CountPrimes(2);
            var actual2 = solution.CountPrimes(11);
            var actual3 = solution.CountPrimes(100);
            var actual4 = solution.CountPrimes(499979);
        }
    }
}
