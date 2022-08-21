public class Solution 
{
    public int LastStoneWeight(int[] stones) 
    {

        var queue = new PriorityQueue<int, int>(new ReverseComparer());
        foreach (var stone in stones)
        {
            queue.Enqueue(stone, stone);
        }       

        while (queue.Count > 1)
        {
            var stone1 = queue.Dequeue();
            var stone2 = queue.Dequeue();
            if (stone1 != stone2)
            {
                int newStone = Math.Abs(stone1 - stone2);
                queue.Enqueue(newStone, newStone);
            }
        }

        return queue.Count > 0 ? queue.Peek() : 0;
    }

    public class ReverseComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}