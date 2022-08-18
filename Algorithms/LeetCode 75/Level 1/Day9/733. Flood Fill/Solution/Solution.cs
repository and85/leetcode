public class Solution
{
    private (int, int)[] _directions = new (int, int)[] 
    {
        (0, 1),
        (0, -1),
        (1, 0),
        (-1, 0),
    };

    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        int oldColor = image[sr][sc];
        
        if (oldColor == newColor) return image;

        Dfs(image, sr, sc, oldColor, newColor);

        return image;
    }

    private void Dfs(int[][] image, int r, int c, int oldColor, int newColor)
    {
        if (image[r][c] != oldColor) return;

        image[r][c] = newColor;
        foreach (var d in _directions)
        {
            int nr = r + d.Item1, nc = c + d.Item2;

            if (InRange(image, r + d.Item1, c + d.Item2))
            {
                Dfs(image, nr, nc, oldColor, newColor);
            }
    }
    }

    private bool InRange(int[][] image, int r, int c)
    {
        return r >= 0 && r < image.Length && c >= 0 && c < image[r].Length;
    }
}