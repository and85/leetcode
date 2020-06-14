using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    // yeah, I unerstand, there should be one pass formula based solution which uses O(1) memory... This one is quite nasty and covers edge cases
    public class Solution
    {
        enum MoveDirection
        {
            Up,
            Down
        }

        public string Convert(string s, int numRows)
        {
            var grid = new List<char[]>();
            char[] currArray = null;

            MoveDirection direction = MoveDirection.Down;
            int xPos = 0, yPos = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (direction == MoveDirection.Down)
                {
                    if (numRows != 2 || yPos == 0)
                    {
                        if (yPos <= 0)
                        {
                            currArray = new char[numRows];
                            grid.Add(currArray);
                        }

                        yPos = (yPos >= 0) ? yPos : 0;
                        currArray[yPos] = s[i];
                        yPos++;
                    }
                    else
                    {
                        if (yPos == -1)
                            yPos = 1;

                        currArray[yPos] = s[i];
                        yPos++;
                    }
                }

                if (direction == MoveDirection.Up)
                {
                    currArray = new char[numRows];
                    grid.Add(currArray);

                    if (yPos == numRows)
                    {
                        // -1 to cover next row shift, - 1 to cover counting from zero
                        yPos = numRows - 2;
                        yPos = (yPos >= 0) ? yPos : 0; 
                    }

                    currArray[yPos] = s[i];
                    yPos--;
                }

                direction = SetMoveDirection(numRows, direction, yPos);
            }

            return BuildResultString(grid, numRows);
        }

        private MoveDirection SetMoveDirection(int numRows, MoveDirection direction, int yPos)
        {
            if (yPos <= 0)
            {
                direction = MoveDirection.Down;
            }

            if (yPos == numRows)
            {
                direction = MoveDirection.Up;
            }

            return direction;
        }

        private string BuildResultString(List<char[]> grid, int numRows)
        {
            var resultSb = new StringBuilder();

            for (int i = 0; i < numRows; i++)
            {
                foreach (var bucket in grid)
                {
                    if (bucket[i] != '\0')
                        resultSb.Append(bucket[i]);
                }
            }

            return resultSb.ToString();
        }
    }
}
