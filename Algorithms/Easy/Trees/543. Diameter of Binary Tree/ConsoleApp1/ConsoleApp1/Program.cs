using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node4 = new TreeNode(4);
            var node5 = new TreeNode(5);

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;

            var s = new Solution();
            Console.WriteLine(s.DiameterOfBinaryTree(node1));
            Console.WriteLine();
        }
    }
}
