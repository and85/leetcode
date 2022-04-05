using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            var hashSet = new HashSet<int>(arr);

            int zeros = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) zeros++;
                if (hashSet.Contains(arr[i] * 2) && arr[i] != 0)
                    return true;
            }

            return zeros >= 2;
        }
    }
}
