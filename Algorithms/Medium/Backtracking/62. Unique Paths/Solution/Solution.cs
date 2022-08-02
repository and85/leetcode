using System.Linq;

public class Solution 
{
    private int _m;
    private int _n;

    private int _uniquePaths;

    private Dictionary<(int, int), int> _memo = new Dictionary<(int, int), int>();

    public int UniquePaths(int m, int n) 
    {
        int[][] dp = new int[m][];

        for (int r = 0; r < m; r++)
        {
            dp[r] = new int[n];
            dp[r][0] = 1;
        }
        for (int c = 0; c < n; c++)
        {
            dp[0][c] = 1;
        }

        for (int r = 1; r < m; r++)
        {
            for (int c = 1; c < n; c++)
            {
                dp[r][c] = dp[r - 1][c] + dp[r][c - 1];
            }
        }

        return dp[m - 1][n - 1];
    }


    // too slow
    public int UniquePaths_Backtracking(int m, int n) 
    {
        _uniquePaths = 0;
        _m = m;
        _n = n;

        Backtrack(1, 1);

        return _uniquePaths;
    }

    private void Backtrack(int curX, int curY)
    {                        
        if (curX > _n) return;
        if (curY > _m) return;        

        if (curX == _n && curY == _m)
        {
            _uniquePaths++;
            return;
        }        

        Backtrack(curX + 1, curY);
        Backtrack(curX, curY + 1);                
    }
}