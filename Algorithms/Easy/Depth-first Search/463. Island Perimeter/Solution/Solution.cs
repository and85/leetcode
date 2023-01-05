public class Solution
{

    private (int R, int C)[] _directions = new (int, int)[]
    {
        (-1, 0),
        (1, 0),
        (0, -1),
        (0, 1)
    };

    private int _width;

    public int IslandPerimeter(int[][] grid)
    {                
        int perimeter = 0;
        for (int r = 0; r < grid.Length; r++)
        { 
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 1)
                {
                    return CalculatePerimiter(grid, r, c);                    
                }
            }
        }


        return 0;
    }

    private int CalculatePerimiter(int[][] grid, int r, int c)
    {
        int perimeter = 0;
        

        var queue = new Queue<(int R, int C)>();        
        
        queue.Enqueue((r, c));

        

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();

            if (grid[cell.R][cell.C] == -1) continue;
            grid[cell.R][cell.C] = -1;

            foreach (var d in _directions)
            {
                int nr = cell.Item1 + d.R;
                int nc = cell.Item2 + d.C;

                if (nr >= 0 && nr < grid.Length && nc >= 0 && nc < grid[r].Length)
                {
                    if (grid[nr][nc] == 1)
                    {                        
                        queue.Enqueue((nr, nc));
                    }
                    else if (grid[nr][nc] == 0)
                    {
                        perimeter++;
                    }
                }
                else
                {
                    perimeter++;
                }
            }
            
        }

        return perimeter;
    }

    public int IslandPerimeter_Recursive(int[][] grid)
    {
        int perimeter = 0;        

        for (int r = 0; r < grid.Length; r++)
        { 
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 1)
                {
                    return Dfs(grid, r, c, ref perimeter);
                }
            }
        }


        return 0;
    }

    private int Dfs(int[][] grid, int r, int c, ref int perimeter)
    {
        //int pos = GetPosition(r, c);

        //if (visited.Contains(pos)) return perimeter;
        //visited.Add(pos);

        if (grid[r][c] == -1) return perimeter;
        grid[r][c] = -1;

        foreach (var d in _directions)
        {
            int nr = r + d.R;
            int nc = c + d.C;

            if (nr >= 0 && nr < grid.Length && nc >= 0 && nc < grid[r].Length)
            {
                if (grid[nr][nc] == 1)
                {
                    Dfs(grid, nr, nc, ref perimeter);
                }
                else if (grid[nr][nc] == 0)
                {
                    perimeter++;
                }
            }
            else
            {
                perimeter++;
            }
        }

        return perimeter;
    }

    private int GetPosition(int i, int j)
    {
        return _width * i + j;
    }
}