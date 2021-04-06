using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public int Distance { get; set; }

            public int Index { get; set; }
        }

        public int NearestValidPoint(int x, int y, int[][] points)
        {
            var validPoints = new List<Point>();

            for (int i = 0; i < points.Length; i++)
            {
                if (IsValid(x, y, points[i]))
                {
                    var point = new Point();
                    point.X = points[i][0];
                    point.Y = points[i][1];
                    point.Distance = CalcualateDistance(x, y, point);
                    point.Index = i;

                    validPoints.Add(point);
                }
            }

            if (validPoints.Count == 0)
                return -1;

            int minIndex = validPoints.First().Index;
            int minDistance = validPoints.First().Distance;

            foreach (var vp in validPoints)
            {
                if (vp.Distance < minDistance)
                {
                    minIndex = vp.Index;
                    minDistance = vp.Distance;
                }
            }

            return minIndex;
        }

        private int CalcualateDistance(int x, int y, Point point)
        {
            return Math.Abs(point.X - x) + Math.Abs(point.Y - y);
        }

        private bool IsValid(int x, int y, int[] p)
        {
            return x == p[0] || y == p[1];
        }
    }
}
