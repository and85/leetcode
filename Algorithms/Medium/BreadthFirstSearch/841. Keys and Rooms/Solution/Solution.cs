public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var queue = new Queue<int>();
        var visited = new HashSet<int>();
        queue.Enqueue(0);

        while (queue.Count > 0)
        {
            var room = queue.Dequeue();

            for (int k = 0; k < rooms[room].Count; k++)
            {
                int key = rooms[room][k];
                if (!visited.Contains(key))
                {
                    queue.Enqueue(key);
                }
            }

            visited.Add(room);
        }

        return visited.Count == rooms.Count;
    }
}