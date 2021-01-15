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


            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node4 = new TreeNode(4);
            var node5 = new TreeNode(5);
            var node6 = new TreeNode(6);
            var node7 = new TreeNode(7);
            var node8 = new TreeNode(8);
            var node9 = new TreeNode(9);

            node5.left = node3;
            node3.right = node6;
            node3.left = node2;
            node3.right = node4;
            node2.left = node1;
            node5.right = node6;
            node6.right = node8;
            node8.left = node7;
            node8.right = node9;

            solution.IncreasingBST(node5);  

            Console.ReadLine();
        }
    }
}
