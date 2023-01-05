public class Solution_attempt1 {

    private int _width;
    public int IslandPerimeter(int[][] grid) {
        
        int pieces = 0;
        var visited = new HashSet<int>();
        _width = grid[0].Length;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    pieces = Dfs(grid, i, j, ref pieces, visited);
                    break;
                }
            }
        }        

        return pieces;
    }

    private (int, int)[] _directions = new[]
    {
        (1, 0),
        (-1, 0),
        (0, 1),
        (0, -1),
    };

    private int Dfs(int[][] grid, int i, int j, ref int pieces, HashSet<int> visited)
    {
        int pos = GetPosition(i, j);

        if (visited.Contains(pos)) return pieces;

        visited.Add(pos);

        foreach (var d in _directions)
        {
            int neighbourI = i + d.Item1;
            int neighbourJ = j + d.Item2;
            if (neighbourI >= grid.Length || neighbourI < 0 || neighbourJ >= grid[i].Length || neighbourJ < 0)
            {
                pieces++;
                continue;
            }            

            if (grid[neighbourI][neighbourJ] == 0)
            {
                pieces++;
            } 
            else
            {
                Dfs(grid, neighbourI, neighbourJ, ref pieces, visited);
            }
        }

        return pieces;
    }

    private int GetPosition(int i, int j)
    {
        return _width * i + j;
    }

}