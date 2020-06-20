using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TicTacToe
    {
        byte[,] _field;
        int _gameSize;

        /** Initialize your data structure here. */
        public TicTacToe(int n)
        {
            _gameSize = n;
            _field = new byte[n, n];
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            SetMove(row, col, player);

            if ((CheckRow(row, col, player)) || 
                (CheckColumn(row, col, player)) || 
                (CheckDiagonal(row, col, player)))
                return player;

            return 0;
        }

        private void SetMove(int row, int col, int player)
        {
            _field[row, col] = (byte)player;
        }

        private bool CheckDiagonal(int row, int col, int player)
        {
            return (IsLeftToRightDiagonal(row, col) && CheckLeftToRightDiagonal(player)) ||
                (IsRightToLeftDiagonal(row, col) && CheckRighToLeftDiagonal(player));
        }

        private bool CheckRighToLeftDiagonal(int player)
        {
            int playerPieces = 0;
            for (int i = 0; i < _gameSize; i++)
            {
                if (_field[i, _gameSize - 1 - i] == player)
                    playerPieces++;
            }

            return IsVictory(playerPieces);
        }

        private bool IsRightToLeftDiagonal(int row, int col)
        {
            return (row == _gameSize - 1 - col);
        }

        private bool CheckLeftToRightDiagonal(int player)
        {
            int playerPieces = 0;
            for (int i = 0; i < _gameSize; i++)
            {
                if (_field[i, i] == player)
                    playerPieces++;
            }

            return IsVictory(playerPieces);
        }

        private bool IsLeftToRightDiagonal(int row, int col)
        {
            return (row == col);
        }

        private bool CheckColumn(int row, int col, int player)
        {
            int playerPieces = 0;
            for (int i = 0; i < _gameSize; i++)
            {
                if (_field[row, i] == player)
                    playerPieces++;
            }

            return IsVictory(playerPieces);
        }

        private bool CheckRow(int row, int col, int player)
        {
            int playerPieces = 0;
            for (int i = 0; i < _gameSize; i++)
            {
                if (_field[i, col] == player)
                    playerPieces++;
            }

            return IsVictory(playerPieces);
        }

        private bool IsVictory(int playerPieces)
        {
            return (playerPieces == _gameSize);
        }
    }

    /**
     * Your TicTacToe object will be instantiated and called as such:
     * TicTacToe obj = new TicTacToe(n);
     * int param_1 = obj.Move(row,col,player);
     */
}
