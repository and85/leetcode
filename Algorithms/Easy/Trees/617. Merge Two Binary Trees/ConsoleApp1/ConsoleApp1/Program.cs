using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var left1 = new TreeNode(1);
            var left3 = new TreeNode(3);
            var left2 = new TreeNode(2);
            var left5 = new TreeNode(5);

            left1.left = left3;
            left1.right = left2;
            left3.left = left5;

            var right2 = new TreeNode(2);
            var right1 = new TreeNode(1);
            var right3 = new TreeNode(3);
            var right4 = new TreeNode(4);
            var right7 = new TreeNode(7);

            right2.left = right1;
            right2.right = right3;
            right1.right = right4;
            right3.right = right7;

            var s = new Solution();
            var res = s.MergeTrees(left1, right2);

            s.MergeTrees(null, new TreeNode(1));

        }
    }
}
