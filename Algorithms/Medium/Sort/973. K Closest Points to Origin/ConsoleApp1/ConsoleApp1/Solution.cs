using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            //return MinHeap(points, k);
            Array.Sort(points, new DistanceCompare2rDesc());

            var result = new int[k][];
            for (int i = 0; i < k; i++)
                result[i] = points[i];

            return result;

        }

        // very slow implementation of min heap which causes timeout exception 
        private int[][] MinHeap(int[][] points, int k)
        {
            var result = new int[k][];
            for (int i = 0; i < k; i++)
                result[i] = new int[] { 0, 0 };

            // Creating Min Heap for given
            // array with only k elements
            // x, y, distance
            var minHeap = new List<(int, int, double)>();
            for (int i = 0; i < k; i++)
            {
                minHeap.Add((points[i][0], points[i][1], GetDistance(points[i][0], points[i][1])));
            }

            // Loop For each element in array
            // after the kth element
            for (int i = k; i < points.Length; i++)
            {
                minHeap.Sort(new DistanceComparerDesc());

                // If current element is smaller
                // than minimum ((top element of
                // the minHeap) element, do nothing
                // and continue to next element
                double distance = GetDistance(points[i][0], points[i][1]);
                if (minHeap[0].Item3 < distance)
                    continue;

                // Otherwise Change minimum element
                // (top element of the minHeap) to
                // current element by polling out
                // the top element of the minHeap
                else
                {
                    minHeap.RemoveAt(0);
                    minHeap.Add((points[i][0], points[i][1], distance));
                }
            }

            // Now min heap contains k maximum
            // elements, Iterate and print  
            for (int i = 0; i < k; i++)
            {
                result[i][0] = minHeap[i].Item1;
                result[i][1] = minHeap[i].Item2;
            }

            return result;
        }

        public class DistanceComparerDesc : Comparer<(int, int, double)>
        {
            // Compares by Length, Height, and Width.
            public override int Compare((int, int, double) x, (int, int, double) y)
            {
                return y.Item3.CompareTo(x.Item3);
            }
        }

        public class DistanceCompare2rDesc : Comparer<int[]>
        {
            // Compares by Length, Height, and Width.
            public override int Compare(int[] p1, int[] p2)
            {
                return GetDistance(p1[0], p1[1]).CompareTo(GetDistance(p2[0], p2[1]));
            }
        }

        private static double GetDistance(int x, int y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
