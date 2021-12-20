using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // task 2: 5935
    public class Solution
    {
        public IList<int> GoodDaysToRobBank(int[] security, int time)
        {
            if (time == 0)
                return Enumerable.Range(0, security.Length).ToList();
            
            var nonIncreasing = new HashSet<int>();
            var nonDecreasing = new HashSet<int>();

            int l = 0;
            for (int i = 1; i < security.Length; i++)
            {
                if (security[i] <= security[i - 1])
                {                    
                    if (++l == time)
                    {
                        nonIncreasing.Add(i);
                        l--;
                    }
                }
                else
                {
                    l = 0;
                }
            }

            l = 0;            
            for (int i = security.Length - 2; i >= 0; i--)
            {
                if (security[i + 1] >= security[i])
                {
                    if (++l == time)
                    {
                        nonDecreasing.Add(i);
                        l--;
                    }
                }
                else
                {
                    l = 0;
                }
            }

            return nonDecreasing.Intersect(nonIncreasing).ToList();
        }
    }
}
