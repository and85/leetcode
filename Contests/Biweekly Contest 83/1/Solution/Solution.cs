public class Solution
{    
    public string BestHand(int[] ranks, char[] suits)
    {
        if (suits.Distinct().Count() == 1) return "Flush";

        int maxRank = ranks.GroupBy(r => r).ToDictionary(g => g, g => g.Count()).Values.Max();

        if (maxRank >= 3) return "Three of a Kind";
        if (maxRank == 2) return "Pair";

        return "High Card";
    }
    
}   
