using System.Text;

public class Solution 
{
    private readonly (int R, int C)[] Directions = new[]
    {
        (1, 0),
        (-1, 0),
        (0, 1),
        (0, -1),
    };


    public bool Exist(char[][] board, string word) 
    {
        /*
        "A","B","C","E"
        "S","F","C","S"
        "A","D","E","E"

        --> ABCCED
        */
        for (int r = 0; r < board.Length; r++)
        {
            for (int c = 0; c < board[r].Length; c++)
            {
                if (board[r][c] == word[0])
                {
                    var visited = new HashSet<(int, int)>();
                    
                    if (Dfs(board, r, c, word, 0, visited)) return true;

                }
            }
        }

        return false;
    }

    private bool Dfs(char[][] board, int r, int c, string word, int wordIndex, HashSet<(int, int)> visited)
    {
        if (wordIndex == word.Length || (word.Length == 1 && word[0] == board[r][c]))
        {
            return true;
        }

        if (word[wordIndex] != board[r][c] || visited.Contains((r, c)))
        {
            return false;
        }

        visited.Add((r, c));

        foreach (var dir in Directions)
        {
            int nr = r + dir.R;
            int nc = c + dir.C;

            if (nr >= 0 && nr < board.Length && nc >= 0 && nc < board[r].Length)
            {
                if (Dfs(board, nr, nc, word, wordIndex + 1, visited)) return true;
            }
        }
        
        // backtrack
        visited.Remove((r, c));

        return false;
    }
}