using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var d1 = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                d1.Add(list1[i], i);
            }

            var d2 = new Dictionary<string, int>();
            for (int i = 0; i < list2.Length; i++)
            {
                d2.Add(list2[i], i);
            }

            int minIndex = int.MaxValue;
            var commom = new Dictionary<String, int>();
            foreach (var l in d1)
            {
                if (d2.ContainsKey(l.Key))
                {
                    int index = l.Value + d2[l.Key];
                    minIndex = Math.Min(minIndex, index);
                    commom.Add(l.Key, index);
                }
            }

            return commom.Where(c => c.Value == minIndex).Select(v => v.Key).ToArray();
         }
    }
}
