using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SparseVector
    {
        public Dictionary<int, int> Nums;

        public SparseVector(int[] nums)
        {
            Nums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    Nums.Add(i, nums[i]);
                }
            }
        }

        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec)
        {
            int sum = 0;
            foreach (var v in this.Nums)
            {
                if (vec.Nums.ContainsKey(v.Key))
                    sum += v.Value * vec.Nums[v.Key];
            }

            return sum;
        }
    }

    // Your SparseVector object will be instantiated and called as such:
    // SparseVector v1 = new SparseVector(nums1);
    // SparseVector v2 = new SparseVector(nums2);
    // int ans = v1.DotProduct(v2);
}
