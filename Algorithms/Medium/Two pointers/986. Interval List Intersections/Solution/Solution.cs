public class Solution {
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList) 
    {
        int p1 = 0, p2 = 0;
        List<int[]> result = new List<int[]>();

        while (p1 < firstList.Length && p2 < secondList.Length)
        {
            if (IsIntersect(firstList[p1], secondList[p2]))
            {
                result.Add(MergeIntervals(firstList[p1], secondList[p2]));
            }

            if (firstList[p1][1] < secondList[p2][1])
            {
                p1++;
            }
            else
            {
                p2++;
            }
        }

        return result.ToArray();
    }

    private int[] MergeIntervals(int[] int1, int[] int2)
    {
        return new int[] { Math.Max(int1[0], int2[0]), Math.Min(int1[1], int2[1]) };
    }

    private bool IsIntersect(int[] int1, int[] int2)
    {
        return (int2[1] >= int1[0] && int2[1] <= int1[1]) || (int1[1] >= int2[0] && int1[1] <= int2[1]);
    }
}