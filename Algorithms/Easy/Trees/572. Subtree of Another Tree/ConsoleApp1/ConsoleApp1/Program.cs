using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             */

            
            var s4 = new TreeNode(4);
            var s1 = new TreeNode(1);
            var s2 = new TreeNode(2);
            s4.left = s1;
            s1.right = s2;

            var t1 = new TreeNode(1);
            var t4 = new TreeNode(4);
            var t2 = new TreeNode(2);
            t1.right = t4;
            t4.left = t2;

            var solutiion = new Solution();
            bool b = solutiion.IsSubtree(s4, t1);
            Console.WriteLine(b);


            Console.ReadLine();
        }
    }
}
