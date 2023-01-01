public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>(new ReverseComparer());
        queue.EnsureCapacity(k);
        var counts = nums.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

        foreach (var c in counts)
        {
            queue.Enqueue(c.Key, c.Value);
        }

        int[] arr = new int[k];

        for (int i = 0; i < k; i++)
        {
            arr[i] = queue.Dequeue();
        }        

        return arr;
    }

    public class ReverseComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {            
            return y.CompareTo(x);
        }
    }
}