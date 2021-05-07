using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int CompareVersion(string version1, string version2)
        {
            var r1 = version1.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            var r2 = version2.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < Math.Max(r1.Length, r2.Length); i++)
            {
                int v1 = 0, v2 = 0;

                if (i < r1.Length)
                    v1 = Convert.ToInt32(r1[i]);

                if (i < r2.Length)
                    v2 = Convert.ToInt32(r2[i]);

                int compare = v1.CompareTo(v2);
                
                if (compare != 0) return compare;
            }

            return 0;
        }
    }
}
