using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Leaderboard
    {
        private Dictionary<int, int> _scores = new Dictionary<int, int>();

        public Leaderboard()
        {

        }

        public void AddScore(int playerId, int score)
        {
            if (_scores.ContainsKey(playerId))
            {
                _scores[playerId] += score;
            }
            else
            {
                _scores.Add(playerId, score);
            }
        }

        public int Top(int K)
        {
            var scores = _scores.Values.ToArray();
           Array.Reverse(scores);
            int sum = 0;
            for (int i = 0; i < K; i++)
            {
                sum += scores[i];
            }

            return sum;
        }

        public void Reset(int playerId)
        {
            _scores[playerId] = 0;
        }
    }
}
