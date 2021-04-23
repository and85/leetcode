using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Solution
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3)
        {
            var res = new List<int>();
            int[] ai = Intersection(arr1, arr2);

            return Intersection(ai, arr3).ToList();
        }

        private int[] Intersection(int[] arr1, int[] arr2)
        {
            return arr1.Intersect(arr2).ToArray();
        }
    }
}
