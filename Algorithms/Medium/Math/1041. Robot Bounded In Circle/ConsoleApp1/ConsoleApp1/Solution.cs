using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private const char Go = 'G';
        private const char Left = 'L';
        private const char Right = 'R';
        private const int StepLength = 1;

        private enum Direction
        {
            North,
            South,
            East,
            West
        }

        private struct Coordinate
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        public bool IsRobotBounded(string instructions)
        {
            Coordinate curPosition = new Coordinate();
            Direction curDirection = Direction.North;

            foreach (char inst in instructions)
            {
                switch (inst)
                {
                    case Go:
                        curPosition = Move(curPosition, curDirection);
                        break;
                    case Left:
                    case Right:
                        curDirection = Rotate(curDirection, inst);
                        break;
                }
            }

            return (IsStayedAtZeroPosition(curPosition))
                || IsDirectionChanged(curDirection);
        }

        private bool IsStayedAtZeroPosition(Coordinate curPosition)
        {
            return curPosition.X == 0 && curPosition.Y == 0;
        }

        private bool IsDirectionChanged(Direction curDirection)
        {
            return curDirection != Direction.North;
        }

        private Direction Rotate(Direction curDirection, char inst)
        {
            switch (curDirection)
            {
                case Direction.North:
                    if (inst.Equals(Left)) curDirection = Direction.West;
                    if (inst.Equals(Right)) curDirection = Direction.East;
                    break;
                case Direction.South:
                    if (inst.Equals(Left)) curDirection = Direction.East;
                    if (inst.Equals(Right)) curDirection = Direction.West;
                    break;
                case Direction.East:
                    if (inst.Equals(Left)) curDirection = Direction.North;
                    if (inst.Equals(Right)) curDirection = Direction.South;
                    break;
                case Direction.West:
                    if (inst.Equals(Left)) curDirection = Direction.South;
                    if (inst.Equals(Right)) curDirection = Direction.North;
                    break;
            }

            return curDirection;
        }

        private Coordinate Move(Coordinate curPosition, Direction curDirection)
        {
            switch (curDirection)
            {
                case Direction.North:
                    curPosition.Y += StepLength;
                    break;
                case Direction.South:
                    curPosition.Y -= StepLength;
                    break;
                case Direction.East:
                    curPosition.X += StepLength;
                    break;
                case Direction.West:
                    curPosition.X -= StepLength;
                    break;
            }

            return curPosition;
        }
    }
}
