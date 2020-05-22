using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        char EmptyPosition = '.';
        const int SubBoxSize = 3;

        public bool IsValidSudoku(char[][] board)
        {
            HashSet<char>[] hashSets = InitHashSetArray(board);

            char currPosition;
            int currSubBox;

            int columnShift = board.Length;
            int subBoxShift = board.Length * 2;
            int jSubBoxShift;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    currPosition = board[i][j];
                    jSubBoxShift = GetJSubBoxJhift(j);
                    currSubBox = i / SubBoxSize + GetJSubBoxJhift(j);

                    if (!IsHashSetValid(hashSets[i], currPosition) ||
                        !IsHashSetValid(hashSets[j + columnShift], currPosition) ||
                        !IsHashSetValid(hashSets[currSubBox + subBoxShift], currPosition))
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }

        private int GetJSubBoxJhift(int j)
        {
            return (j / SubBoxSize) * SubBoxSize;
        }

        private bool IsHashSetValid(HashSet<char> hashSet, char element)
        {
            if (!hashSet.Contains(element))
            {
                if (element != EmptyPosition)
                    hashSet.Add(element);
            }
            else
            {
                return false;
            }

            return true;
        }

        private HashSet<char>[] InitHashSetArray(char[][] board)
        {
            int boardSquare = board.Length * board.Length;
            int subBoxSquare = SubBoxSize * SubBoxSize;
            int subBoxNum = boardSquare / subBoxSquare;
            // amount of columns + amount of rows + amount of sub-boxes
            int uniqueHashSetNum = board.Length * 2 + subBoxNum;
 
            HashSet<char>[] rowColumnHashSet = new HashSet<char>[uniqueHashSetNum];
            for (int i = 0; i < uniqueHashSetNum; i++)
                rowColumnHashSet[i] = new HashSet<char>();
            return rowColumnHashSet;
        }
    }
}
