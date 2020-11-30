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
            var n0 = new TreeNode(0);
            var n1 = new TreeNode(1);
            var n2 = new TreeNode(2);
            var n3 = new TreeNode(3);
            var n4 = new TreeNode(4);
            var n5 = new TreeNode(5);
            var n6 = new TreeNode(6);

            /*
              0
            /  \
           1    2
          / \  / \
         3  5  6  4
            */
            n0.left = n1;
            n0.right = n2;
            n1.left = n3;
            n1.right = n5;
            n2.left = n6;
            n2.right = n4;

            Console.WriteLine("Recursive");
            foreach (var node in new SolutionRecursive().PreorderTraversal(n0))
                Console.WriteLine(node);

            Console.WriteLine("Iterative");
            foreach (var node in new Solution().PreorderTraversal(n0))
                Console.WriteLine(node);

            foreach (var node in new Solution().PreorderTraversal(null))
                Console.WriteLine(node);

            Console.WriteLine("Iterative inorder");
            foreach (var node in new Solution().InorderTraversal(n0))
                Console.WriteLine(node);

            Console.ReadLine();
        }
    }
}
