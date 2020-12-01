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
            /*
                 3
                / \
               9  20
                  / \
                 15  7
            */
            var node3 = new TreeNode(3);
            var node9 = new TreeNode(9);
            var node20 = new TreeNode(20);
            var node15 = new TreeNode(15);
            var node7 = new TreeNode(7);

            node3.left = node9;
            node3.right = node20;
            node20.left = node15;
            node20.right = node7;
            Solve(node3);
            SolveRecursive(node3);

            Console.ReadLine();
        }

        private static void Solve(TreeNode node3)
        {
            var solution = new Solution();
            var result = solution.LevelOrder(node3);
            foreach (var level in result)
            {
                foreach (var node in level)
                {
                    Console.Write(node + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SolveRecursive(TreeNode node3)
        {
            var solution = new SolutionRecursive();
            var result = solution.LevelOrder(node3);
            foreach (var level in result)
            {
                foreach (var node in level)
                {
                    Console.Write(node + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
