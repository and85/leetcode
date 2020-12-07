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

            Console.ReadLine();
        }

        private static void Test1()
        {
            var node3 = new TreeNode(3);
            var node5 = new TreeNode(5);
            var node1 = new TreeNode(1);
            var node6 = new TreeNode(6);
            var node2 = new TreeNode(2);
            var node0 = new TreeNode(0);
            var node8 = new TreeNode(8);
            var node7 = new TreeNode(7);
            var node4 = new TreeNode(4);

            node3.left = node5;
            node3.right = node1;
            node5.left = node6;
            node5.right = node2;
            node1.left = node0;
            node1.right = node8;
            node2.left = node7;
            node2.right = node4;

            var solution = new Solution();
            var res1 = solution.LowestCommonAncestor(node3, node5, node1);
            Console.WriteLine(res1.val);

            var res2 = solution.LowestCommonAncestor(node3, node5, node4);
            Console.WriteLine(res2.val);

            var res3 = solution.LowestCommonAncestor(node3, node0, node8);
             Console.WriteLine(res3.val);
        }

        private static void Test2()
        {
            var node37 = new TreeNode(37);
            var node_34 = new TreeNode(-34);
            var node_48 = new TreeNode(-48);
            var node48 = new TreeNode(48);
            var node_100 = new TreeNode(-100);
            var node101 = new TreeNode(101);
            var node_54 = new TreeNode(-54);
            var node_71 = new TreeNode(-71);

            node37.left = node_34;
            node37.right = node_48;
            node_34.right = node_100;
            node_48.left = node101;
            node_48.right = node48;
            node48.right = node_54;
            node_54.right = node_71;

            var solution = new Solution();
            var res = solution.LowestCommonAncestor(node37, node_71, node48);
            Console.WriteLine(res);
        }

    }
}
