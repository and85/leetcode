public class Solution
{
    private (int, int)[] _directions = new (int, int)[] 
    {
        (0, 1),
        (0, -1),
        (1, 0),
        (-1, 0),
    };

    public int NumIslands(char[][] grid)
    {
        int islands = 0;

        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == '1')
                {
                    islands++;
                    Dfs(grid, r, c);
                }
            }
        }

        return islands;
    }

    private void Dfs(char[][] grid, int r, int c)
    {
        if (grid[r][c] == '0') return;

        grid[r][c] = '0';
        foreach (var d in _directions)
        {
            int nr = r + d.Item1, nc = c + d.Item2;

            if (InRange(grid, r + d.Item1, c + d.Item2))
            {
                Dfs(grid, nr, nc);
            }
    }
    }

    private bool InRange(char[][] grid, int r, int c)
    {
        return r >= 0 && r < grid.Length && c >= 0 && c < grid[r].Length;
    }
}