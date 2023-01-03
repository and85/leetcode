public class Solution
{
    private (int, int)[] _directions = new[]
    {
        (0, 1),
        (0, -1),
        (1, 0),
        (-1, 0),
    };

    public int MaxDistance(int[][] grid)
    {
        bool landFound = false;
        bool waterFound = false;
        var queue = new Queue<(int, int)>();
        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 1)
                {                    
                    queue.Enqueue((r, c));
                    landFound = true;
                }
                else
                {
                    waterFound = true;
                }
            }
        }

        if (!(landFound && waterFound)) return -1;

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();

            foreach (var dir in _directions)
            {
                var nr = cell.Item1 + dir.Item1;
                var nc = cell.Item2 + dir.Item2;

                if (nr >= 0 && nr < grid.Length && nc >= 0 && nc < grid[nr].Length)
                {
                    if (grid[nr][nc] == 0)
                    {
                        queue.Enqueue((nr, nc));

                        if (grid[cell.Item1][cell.Item2] == 1)
                        {
                            grid[nr][nc] = -1;
                        }
                        else
                        {
                            if (grid[nr][nc] < 0)
                            {
                                //grid[nr][nc] = -Math.Min(Math.Abs(grid[cell.Item1][cell.Item2] - 1), Math.Abs(grid[nr][nc]
                                grid[nr][nc] =Math.Abs(grid[cell.Item1][cell.Item2] - 1);
                            }
                            else
                            {
                                grid[nr][nc] = grid[cell.Item1][cell.Item2] - 1;
                            }
                        }
                    }                    
                }
            }
        }

        int min = int.MaxValue;
        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {
                min = Math.Min(grid[r][c], min);
            }
        }

        return Math.Abs(min);
    }
}