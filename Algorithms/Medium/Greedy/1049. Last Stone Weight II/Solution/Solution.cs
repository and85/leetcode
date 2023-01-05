public class Solution
{
    public int LastStoneWeightII(int[] stones)
    {
        var queue = new SortedSet<int>(stones);                

        while (queue.Count > 1)
        {
            int maxStone = queue.Max();
            int minStone = queue.Min();
            queue.Remove(maxStone);
            queue.Remove(minStone);

            int remainedStone = Math.Abs(maxStone - minStone);

            if (remainedStone != 0)
            {
                queue.Add(remainedStone);
            }            
        }

        return queue.Count == 1 ? queue.Max : 0;
    }    
}