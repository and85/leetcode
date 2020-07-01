using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10);
            TreeNode l1 = new TreeNode(5);
            TreeNode r1 = new TreeNode(15);

            TreeNode l2 = new TreeNode(3);
            TreeNode r2 = new TreeNode(7);
            TreeNode r3 = new TreeNode(18);

            root.left = l1;
            root.right = r1;
            l1.left = l2;
            l1.right = r2;
            r1.right = r3;

            var solution = new Solution();
            int a = solution.RangeSumBST(root, 7, 15);
            Console.ReadLine();
        }
    }
}
