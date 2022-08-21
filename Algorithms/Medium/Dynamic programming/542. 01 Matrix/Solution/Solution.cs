public class Solution 
{
    private (int, int)[] _directions = new (int, int)[]
    {
        (1, 0),
        (-1, 0),
        (0, 1),
        (0, -1)
    };    

    public int[][] UpdateMatrix(int[][] mat)
    {
        /*
        Algorithm
        For our BFS routine, we keep a queue, q to maintain the queue of cells to be examined next.
        We start by adding all the cells with 0s to q.
        Intially, distance for each 0 cell is 0 and distance for each 1 is INT_MAX, which is updated during the BFS.
        Pop the cell from queue, and examine its neighbors. If the new calculated distance for neighbor {i,j} is smaller, we add {i,j} to q and update dist[i][j].
        */        
        InitDist(mat, out var dist, out var queue);        

        while (queue.Count > 0)
        {
            var cell = queue.Dequeue();

            foreach (var d in _directions)
            {
                int nr = cell.Item1 + d.Item1;
                int nc = cell.Item2 + d.Item2;

                if (InRange(mat, nr, nc))
                {
                    int newDistance = dist[cell.Item1][cell.Item2] + 1;
                    if (newDistance < dist[nr][nc])
                    {
                        dist[nr][nc] = newDistance;
                        queue.Enqueue((nr, nc));
                    }
                }
            }
        }

        return dist;
    }

    private void InitDist(int[][] mat, out int[][] dist, out Queue<(int, int)> queue)
    {
        dist = new int[mat.Length][];
        queue = new Queue<(int, int)>();
        for (int r = 0; r < mat.Length; r++)
        {
            dist[r] = new int[mat[r].Length];
        }

        for (int r = 0; r < mat.Length; r++)
        for (int c = 0; c < mat[r].Length; c++)
        {
            if ((mat[r][c]) == 0)
            {
                queue.Enqueue((r, c));
            }
            else
            {
                dist[r][c] = int.MaxValue;
            }
        }        
    }

    private bool InRange(int[][] mat, int r, int c)
    {
        return r >= 0 && r < mat.Length && c >= 0 && c < mat[r].Length;
    }
}