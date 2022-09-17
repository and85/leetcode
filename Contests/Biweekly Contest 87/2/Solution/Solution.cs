public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) 
    {
        Array.Sort(players);
        Array.Sort(trainers);

        int p = 0, t = 0, matched = 0;

        while (p < players.Length && t < trainers.Length)
        {
            if (players[p] <= trainers[t])
            {
                matched++;
                p++;
                t++;
            }
            else
            {
                t++;
            }
        }

        return matched;
    }
}