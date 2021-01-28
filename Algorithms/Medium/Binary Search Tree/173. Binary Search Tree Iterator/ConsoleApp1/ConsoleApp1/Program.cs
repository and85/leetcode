using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);

            node2.left = node1;
            node2.right = node3;

            var solution = new BSTIterator(node2);

            Console.WriteLine(solution.HasNext());
            Console.WriteLine(solution.Next());

            Console.WriteLine(solution.HasNext());
            Console.WriteLine(solution.Next());

            Console.WriteLine(solution.HasNext());
            Console.WriteLine(solution.Next());

            Console.WriteLine(solution.HasNext());

            

            Console.ReadLine();
        }
    }
}
