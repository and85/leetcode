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

            var t4 = new TreeNode(4);
            var t2 = new TreeNode(2);
            var t5 = new TreeNode(5);
            var t1 = new TreeNode(1);
            var t3 = new TreeNode(3);

            t4.left = t2;
            t4.right = t5;
            t2.left = t1;
            t2.right = t3;

            var solution = new Solution();
            solution.ClosestValue(t4, 3.714286);

            Console.ReadLine();
        }
    }
}
