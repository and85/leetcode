using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var groups = new Dictionary<int, IList<IList<int>>>();            

            for (int i = 0; i < groupSizes.Length; i++)
            {
                int size = groupSizes[i];
                if (!groups.ContainsKey(size))
                {
                    groups.Add(size, new List<IList<int>>());
                    groups[size].Add(new List<int>());                    
                }
                else
                {
                    if (groups[size].Last().Count == size)
                        groups[size].Add(new List<int>());                    
                }

                groups[size].Last().Add(i);

            }


            return groups.Values.SelectMany(g => g).ToList();
        }
    }
}
