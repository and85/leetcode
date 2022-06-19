public class Solution {
    public int NumSpecial(int[][] mat)
    {
        var rows = new Dictionary<int, int>();
        var columns = new Dictionary<int, int>();

        for (int r = 0; r < mat.Length; r++)
        for (int c = 0; c < mat[r].Length; c++)
        {
            if (mat[r][c] == 1)
            {
                CountEntries(rows, r);
                CountEntries(columns, c);
            }
        }

        return Math.Min(rows.Values.Count(v => v ==1), columns.Values.Count(v => v ==1));
    }

    private void CountEntries(Dictionary<int, int> dict, int k)
    {
        if (dict.ContainsKey(k))
        {
            dict[k]++;
        }
        else
        {
            dict.Add(k, 1);
        }
    }
}