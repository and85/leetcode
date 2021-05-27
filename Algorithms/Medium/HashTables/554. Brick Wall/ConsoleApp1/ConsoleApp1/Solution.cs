using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int LeastBricks(IList<IList<int>> wall)
        {
            var ends = new Dictionary<int, int>();

            foreach (var row in wall)
            {
                int currEnd = 0;
                // don't consider end of the last brick
                int i;
                for (i = 0; i < row.Count - 1; i++)
                {
                    currEnd += row[i];
                    if (!ends.ContainsKey(currEnd))
                        ends.Add(currEnd, 1);
                    else
                        ends[currEnd]++;
                }
            }

            int mostFrequent = ends.Values.Count > 0 ? ends.Values.Max() : 0;

            return wall.Count - mostFrequent;
        }
    }
}
