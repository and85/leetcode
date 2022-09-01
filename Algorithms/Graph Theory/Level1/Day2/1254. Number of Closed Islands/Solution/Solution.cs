public class Solution
{

    private (int, int)[] _directions = new[]
    {
        (1, 0),
        (-1, 0),
        (0, 1),
        (0, -1)
    };

    private HashSet<(int, int)> _visited = new HashSet<(int, int)>();

    public int ClosedIsland(int[][] grid)
    {
        int res = 0;

        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {                
                if (_visited.Contains((r, c))) continue;

                if (grid[r][c] == 0)
                {

                    bool canReach = false;
                    CanReachOutBoundaries(grid, r, c, ref canReach);
                    res += Convert.ToInt32(!canReach);
                }
            }
        }

        return res;
    }

    private void CanReachOutBoundaries(int[][] grid, int r, int c, ref bool result)
    {                        
        _visited.Add((r, c));

        foreach (var d in _directions)
        {
            int nr = r + d.Item1;
            int nc = c + d.Item2;

            bool inRange = InRange(grid, nr, nc);
            if (inRange && grid[nr][nc] == 0)
            {
                if (!_visited.Contains((nr, nc)))
                {
                    CanReachOutBoundaries(grid, nr, nc, ref result);
                }
            }

            if (!inRange)
            {
                result = true;
            }

        }        
    }

    private bool InRange(int[][] grid, int nr, int nc)
    {        
        return (nr >= 0 && nr < grid.Length && nc >= 0 && nc < grid[nr].Length);
    }
}