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
        public int FirstIndex = -1;
        public int LastIndex;

        public SparseVector(int[] nums)
        {
            Nums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (FirstIndex == -1)
                        FirstIndex =  i;
                    LastIndex = i;
                    
                    Nums.Add(i, nums[i]);
                }
            }
        }

        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec)
        {
            int minIndex = Math.Max(this.FirstIndex, vec.FirstIndex);
            int maxIndex = Math.Max(this.LastIndex, vec.LastIndex);
            int sum = 0;
            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (this.Nums.ContainsKey(i) && vec.Nums.ContainsKey(i))
                    sum += this.Nums[i] * vec.Nums[i];
            }

            return sum;
        }
    }

    // Your SparseVector object will be instantiated and called as such:
    // SparseVector v1 = new SparseVector(nums1);
    // SparseVector v2 = new SparseVector(nums2);
    // int ans = v1.DotProduct(v2);
}
