using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution : VersionControl
    {
        public int FirstBadVersion(int n)
        {
            // g g g b b b b b b b b b b b 
            // b g g g g g g g g 

            int l = 1, r = n;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (IsBadVersion(m))
                {
                    r = m - 1;
                }
                else
                {
                    l = m + 1;
                }
            }

            return l;
                    
        }
    }
}
