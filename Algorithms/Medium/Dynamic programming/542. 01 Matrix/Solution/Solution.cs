public class Solution 
{
    private (int, int)[] _directions = new (int, int)[]
    {
        (1, 0),
        (-1, 0),
        (0, 1),
        (0, -1)
    };

    Dictionary<(int, int), int> _visited = new Dictionary<(int, int), int>();

    public int[][] UpdateMatrix(int[][] mat) 
    {
        for (int r = 0; r < mat.Length; r++)
        {
            for (int c = 0; c < mat[r].Length; c++)
            {
                if (_visited.ContainsKey((r, c)))
                {
                    continue;
                }

                GetDistance(mat, r, c, 0);
            }
        }

        for (int r = 0; r < mat.Length; r++)
        {
            for (int c = 0; c < mat[r].Length; c++)
            {
                mat[r][c] = _visited[(r, c)];
            }
        }

        return mat;
    }

    private void GetDistance(int[][] mat, int r, int c, int curDistance)
    {
        if (mat[r][c] == 0)
        {
            _visited.Add((r, c), curDistance);
            return;
        }

        foreach (var d in _directions)
        {
            if (InRange(mat, r + d.Item1, c + d.Item1))
            {

            }
        }
    }

    private bool InRange(int[][] mat, int r, int c)
    {
        return r >= 0 && r < mat.Length && c >= 0 && c < mat[r].Length;
    }
}