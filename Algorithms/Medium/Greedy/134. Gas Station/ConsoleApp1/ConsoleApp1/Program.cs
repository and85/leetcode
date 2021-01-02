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
            Console.WriteLine(solution.CanCompleteCircuit(
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 3, 4, 5, 1, 2 }));

            Console.WriteLine(solution.CanCompleteCircuit(
                new int[] { 2, 3, 4 },
                new int[] { 3, 4, 3 }));

            var leetCodeSolution = new LeetCodeSolution();
            Console.WriteLine(leetCodeSolution.canCompleteCircuit(
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 3, 4, 5, 1, 2 }));

            Console.ReadLine();
        }
    }
}
