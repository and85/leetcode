public class Solution {
    public int MinimumCardPickup(int[] cards) 
    {
        var lastSeen = new Dictionary<int, int>();
        int min = int.MaxValue;

        for (int i = 0; i < cards.Length; i++)
        {
            int card = cards[i];
            if (!lastSeen.ContainsKey(card))
            {
                lastSeen.Add(card, i);
                continue;
            }

            min = Math.Min(min, i - lastSeen[card] + 1);
            lastSeen[card] = i;
        }    

        return min != int.MaxValue ? min : -1;
    }
}