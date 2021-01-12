using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private char[][] _board;
        public int CountBattleships(char[][] board)
        {
            _board = board;

            int ships = 0;
            for (int r = 0; r < _board.Length; r++)
                for (int c = 0; c < _board[r].Length; c++)
                {
                    if (_board[r][c] == 'X')
                    {
                        Dfs(r, c);
                        ships++;
                    }
                }

            return ships;
        }

        private void Dfs(int r, int c)
        {
            _board[r][c] = '.';

            if (r < _board.Length - 1 && _board[r + 1][c] == 'X')
                Dfs(r + 1, c);
            
            if (r > 0 && _board[r - 1][c] == 'X')
                Dfs(r - 1, c);

            if (c < _board[r].Length -1 && _board[r][c + 1] == 'X')
                Dfs(r, c + 1);

            if (c > 0 && _board[r][c - 1] == 'X')
                Dfs(r, c - 1);
        }
    }
}
