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

            var solution = new Solution();
            var actual = solution.BalanceBST(node1);

            Console.ReadLine();
        }
    }
}
