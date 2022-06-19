public class Solution
{

    private int[][] _directions = new int[][]
    {
        new[] {1, 0},
        new[] {-1, 0},
        new[] {0, 1},
        new[] {0, -1}
    };

    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        int height = image.Length;
        int width = image[0].Length;

        int oldColor = image[sr][sc];
        var queue = new Queue<(int, int)>();
        queue.Enqueue((sr, sc));
        var visited = new HashSet<(int, int)>();

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();
            
            if (visited.Contains(cell)) continue;
            
            foreach (var dir in _directions)
            {
                int nr = cell.Item1 + dir[0];
                int nc = cell.Item2 + dir[1];

                if (nr >= height || nr < 0 || nc >= width || nc < 0)
                {
                    continue;
                }

                if (image[nr][nc] == oldColor)
                {
                    queue.Enqueue((nr, nc));
                }
            }

            image[cell.Item1][cell.Item2] = newColor;
            visited.Add(cell);
        }

        return image;
    }       
}