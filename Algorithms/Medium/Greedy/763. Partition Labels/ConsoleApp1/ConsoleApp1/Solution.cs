using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<int> PartitionLabels(string s)
        {
            // key by index, first appearance, last appearance 
            (int, int)[] positions = new (int, int)[26];
            for (int i = 0; i < 26; i++)
            {
                positions[i].Item1 = -1;
                positions[i].Item2 = -1;
            }

            int index;
            for (int i = 0; i < s.Length; i++)
            {
                index = s[i] - 97;
                if (positions[index].Item1 == -1)
                    positions[index].Item1 = i;

                if (i > positions[index].Item2)
                    positions[index].Item2 = i;
            }

            var result = new List<int>();
            int p = 0, startPointer = 0, endPointer = -1;

            while (p < s.Length)
            {
                index = s[p] - 97;
                if (positions[index].Item2 > endPointer)
                    endPointer = positions[index].Item2;

                if (p == endPointer)
                {
                    result.Add(endPointer - startPointer + 1);
                    startPointer = p + 1;
                }
                
                p++;
            }

            return result;
        }
    }
}
