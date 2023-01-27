public class Solution 
{
    public int MinPathSum(int[][] grid) 
    {
        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (c == 0 && r == 0) continue;

                if (c == 0)
                {
                    grid[r][c] = grid[r - 1][c] + grid[r][c];    
                }
                else if (r == 0)
                {
                    grid[r][c] = grid[r][c - 1] + grid[r][c];    
                }
                else
                {
                    grid[r][c] = Math.Min(grid[r][c - 1],  grid[r - 1][c]) + grid[r][c];
                }                
            }
        }

        return grid[grid.Length - 1][grid[0].Length - 1];

    }
}