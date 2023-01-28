public class Solution 
{
    public int[] FindOrder(int numCourses, int[][] prerequisites) 
    {
        var adjacencyList = new Dictionary<int, HashSet<int>>();
        var output = new List<int>();        

        for (int i = 0; i < prerequisites.Length; i++)
        {
            int v = prerequisites[i][0];
            int p = prerequisites[i][1];
            if (!adjacencyList.ContainsKey(v))
            {
                adjacencyList.Add(v, new HashSet<int>());
            }
            adjacencyList[v].Add(p);
        }

        for (int i = 0; i < numCourses; i++)
        {
            if (!adjacencyList.ContainsKey(i))
            {
                adjacencyList.Add(i, new HashSet<int>());
            }
        }
        
        while (adjacencyList.Count > 0)
        {
            var queue = new Queue<int>();

            bool rootFound = false;
            foreach (var v in adjacencyList)
            {
                if (v.Value.Count == 0)
                {
                    output.Add(v.Key);
                    queue.Enqueue(v.Key);
                    rootFound = true;                    
                    
                    adjacencyList.Remove(v.Key);
                }
            }

            if (!rootFound)  return  new int[] {};

            while (queue.Count > 0)
            {
                var q = queue.Dequeue();
                foreach (var v in adjacencyList)
                {
                    if (v.Value.Contains(q))
                    {
                        v.Value.Remove(q);
                    }
                }    
            }
        }

        return output.ToArray();
    }
}