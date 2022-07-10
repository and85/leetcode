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
            s4.right = s2;

            var t1 = new TreeNode(1);
            var t4 = new TreeNode(4);
            var t2 = new TreeNode(2);
            var t3 = new TreeNode(3);
            var t5 = new TreeNode(5);
            var t0 = new TreeNode(0);

            t3.left = t4;
            t3.right = t5;
            t4.left = t1;
            t4.right = t2;
            t2.left = t0;


            var solutiion = new Solution();
            bool b = solutiion.IsSubtree(t3, s4);
            Console.WriteLine(b);


            Console.ReadLine();
        }
    }
}
