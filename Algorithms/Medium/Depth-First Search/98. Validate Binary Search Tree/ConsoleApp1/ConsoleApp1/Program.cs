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
            var node5 = new TreeNode(5);
            var node4 = new TreeNode(4);
            var node6 = new TreeNode(6);
            var node3 = new TreeNode(3);
            var node7 = new TreeNode(7);

            node5.left = node4;
            node5.right = node6;
            node6.left = node3;
            node6.right = node7;

            var solution = new Solution();
            Console.WriteLine(solution.IsValidBST(node5));

            Console.ReadLine();
        }
    }
}
