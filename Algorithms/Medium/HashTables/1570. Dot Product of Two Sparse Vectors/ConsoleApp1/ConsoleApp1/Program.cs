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
            SparseVector v1 = new SparseVector(new int[] { 1, 0, 0, 2, 3 });
            SparseVector v2 = new SparseVector(new int[] { 0, 3, 0, 4, 0 });
            int ans = v1.DotProduct(v2);
            Console.WriteLine(ans);

            Console.ReadLine();
        }
    }
}
