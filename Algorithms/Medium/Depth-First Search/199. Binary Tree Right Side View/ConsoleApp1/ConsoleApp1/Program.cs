using System;
using System.Linq;
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
            /*
                 1     <-  1
               /  \ 
              2    3   <-  3
             /  \   \
            6    5   4 <-- 4
            /
           7 <------------ 7
                             
            */
            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node5 = new TreeNode(5);
            var node4 = new TreeNode(4);
            var node6 = new TreeNode(6);
            var node7 = new TreeNode(7);

            node1.left = node2;
            node1.right = node3;
            node2.right = node5;
            node3.right = node4;
            node2.left = node6;
            node6.left = node7;

            var solution = new Solution();
            foreach (var n in solution.RightSideView(node1))
                Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
