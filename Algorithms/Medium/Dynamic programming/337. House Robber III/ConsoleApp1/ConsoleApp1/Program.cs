using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var node31 = new TreeNode(3);
            var node2 = new TreeNode(2);
            var node32 = new TreeNode(3);
            var node33 = new TreeNode(3);
            var node1 = new TreeNode(1);

            var solution = new Solution();
            solution.Rob(node31);
        }
    }
}
