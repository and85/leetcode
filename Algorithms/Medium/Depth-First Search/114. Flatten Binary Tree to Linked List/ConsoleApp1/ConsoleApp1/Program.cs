using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);

            n1.left = n2;
            n1.right = n5;
            n2.left = n3;
            n2.right = n4;
            n5.right = n6;

            var solution = new Solution();
            solution.Flatten(n1);

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
