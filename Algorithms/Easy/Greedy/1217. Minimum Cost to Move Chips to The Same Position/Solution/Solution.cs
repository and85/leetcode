public class Solution {
    public int MinCostToMoveChips(int[] position) 
    {
        return Math.Min(position.Count(p => p % 2 == 0), position.Count(p => p % 2 == 1));
    }
}