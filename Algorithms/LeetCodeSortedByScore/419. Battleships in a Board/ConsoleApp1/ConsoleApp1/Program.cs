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

            solution.CountBattleships(new char[][]
            {
                new char[] { 'X', '.', '.', 'X' },
                new char[] { '.', '.', '.', 'X' },
                new char[] { '.', '.', '.', 'X' }
            });

            solution.CountBattleships(new char[][]
            {
                new char[] { 'X', 'X', 'X' }
            });

            Console.ReadLine();
        }
    }
}
