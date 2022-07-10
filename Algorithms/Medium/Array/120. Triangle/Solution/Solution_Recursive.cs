public class Solution
{
    // https://medium.com/@gepphkat/dynamic-programming-120-triangle-50c44a666813
    private Dictionary<(int, int), int> _memo = new Dictionary<(int, int), int>();

    public int MinimumTotal(IList<IList<int>> triangle)
    {
        return findMinPath(triangle, 0, 0);
    }

    public int findMinPath(IList<IList<int>> triangle, int rowNum, int index)
    {
        IList<int> row = triangle[rowNum];
        // base case, we are at the last row
        if (rowNum == triangle.Count - 1)
        {
            return row[index];
        }

        if (_memo.ContainsKey((rowNum, index)))
        {
            return _memo[(rowNum, index)];
        }

        int currentValue = row[index];
        int maxSumLeft = findMinPath(triangle, rowNum + 1, index);
        int maxSumRight = findMinPath(triangle, rowNum + 1, index + 1);
        int sumPath = currentValue + Math.Min(maxSumLeft, maxSumRight);
        _memo.Add((rowNum, index), sumPath);

        return sumPath;
    }
}