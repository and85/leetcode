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
            Robot robot = new NullRobot();
            solution.CleanRoom(robot);
            Console.ReadLine();
        }
    }
}
