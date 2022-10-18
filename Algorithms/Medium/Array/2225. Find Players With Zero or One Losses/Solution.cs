public class Solution
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        // player, losses
        var players = new Dictionary<int, int>();

        foreach (var match in matches)
        {
            int winner = match[0];
            int loser = match[1];
            
            if (!players.ContainsKey(winner))
            {
                players.Add(winner, 0);
            }

            if (!players.ContainsKey(loser))
            {
                players.Add(loser, 0);
            }

            players[loser]++;
        }

        var nolosses = players.Where(p => p.Value == 0).OrderBy(p => p.Key).Select(p => p.Key).ToList();
        var oneloss = players.Where(p => p.Value == 1).OrderBy(p => p.Key).Select(p => p.Key).ToList();

        return new List<IList<int>>() { nolosses, oneloss };
    }
}