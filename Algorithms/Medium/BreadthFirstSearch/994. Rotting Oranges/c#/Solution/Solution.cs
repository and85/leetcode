public class Solution {
    private (int, int)[] _directions = new(int, int)[]
    {
        (1, 0),
        (-1, 0),
        (0, 1),
        (0, -1)
    };

    public int orangesRotting(int[][] grid) {

        
    }

    

    private bool InRange(int[][] grid, int r, int c)
    {
        return false;
    }

    private bool FreshExists(int[][] grid)
    {        
        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] == 1)
                {                    
                    return true;
                }
            }
        }

        return false;
    }
}