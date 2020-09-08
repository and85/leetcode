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

            node1.right = node2;
            node2.left = node3;

            var solution = new Solution();
            solution.InorderTraversal(node1);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
