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
            var node1 = new TreeNode(5);
            var node2 = new TreeNode(1);
            var node3 = new TreeNode(5);
            var node4 = new TreeNode(5);
            var node5 = new TreeNode(1);
            var node6 = new TreeNode(6);

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.right = node6;

            var solution = new Solution();
            Console.WriteLine(solution.CountUnivalSubtrees(node1));

            Console.ReadLine();
        }
    }
}
