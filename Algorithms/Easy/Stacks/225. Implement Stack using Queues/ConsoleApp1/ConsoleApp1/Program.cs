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
            int x = 1;
            MyStack obj = new MyStack();
            obj.Push(x);
            int param_2 = obj.Pop();
            int param_3 = obj.Top();
            bool param_4 = obj.Empty();

            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
