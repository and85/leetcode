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
            var s = new Solution();

            var n1 = new ListNode(1);
            ////var n2 = new ListNode(2);
            ////var n3 = new ListNode(3);
            ////var n4 = new ListNode(4);

            ////n1.next = n2;
            ////n2.next = n3;
            ////n3.next = n4;

            s.SwapPairs(n1);


            Console.ReadLine();
        }
    }
}
