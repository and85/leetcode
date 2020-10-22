using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test2();

            Console.ReadLine();

        }

        private static void Test1()
        {
            var node3 = new TreeNode(3);
            var node9 = new TreeNode(9);
            var node20 = new TreeNode(20);
            var node15 = new TreeNode(15);
            var node7 = new TreeNode(7);

            node3.left = node9;
            node3.right = node20;
            node20.left = node15;
            node20.right = node7;

            var solution = new Solution();
            solution.ZigzagLevelOrder(node3);
        }

        private static void Test2()
        {
            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node4 = new TreeNode(4);
            var node5 = new TreeNode(5);

            node1.left = node2;
            node2.left = node4;
            node1.right = node3;
            node3.right = node5;

            var solution = new Solution();
            solution.ZigzagLevelOrder(node1);
        }
    }
}
