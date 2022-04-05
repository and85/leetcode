using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var node3 = new TreeNode(3);
            var node9 = new TreeNode(9);
            var node8 = new TreeNode(8);
            var node4 = new TreeNode(4);
            var node0 = new TreeNode(0);
            var node1 = new TreeNode(1);
            var node7 = new TreeNode(7);
            var node2 = new TreeNode(2);
            var node5 = new TreeNode(5);

            node3.left = node9;
            node3.right = node8;
            node9.left = node4;
            node9.right = node0;
            node8.left = node1;
            node8.right = node7;
            node0.right = node2;
            node1.left = node5;

            solution.VerticalOrder(node3);
        }
    }
}
