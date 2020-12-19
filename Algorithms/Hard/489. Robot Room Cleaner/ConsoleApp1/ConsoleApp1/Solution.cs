using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Solution
    {
        public struct Coordinate: IEquatable<Coordinate>
        {
            public Coordinate(int row, int column)
            {
                Row = row;
                Column = column;
            }

            public int Row { get; set; }
            public int Column { get; set; }

            public bool Equals(Coordinate other)
            {
                return Row == other.Row && Column == other.Column;
            }

            public override int GetHashCode()
            {
                return Row.GetHashCode() * 17 + Column.GetHashCode();
            }

            public override string ToString()
            {
                return Row.ToString() + " " + Column.ToString();
            }
        }

        public enum Direction
        {
            Up = 0,
            Right = 1,
            Down = 2,
            Left = 3,
            NoWay = 4
        }

        private Dictionary<Coordinate, int> _visitedCells = new Dictionary<Coordinate, int>();
        private HashSet<Coordinate> _cleanedCells = new HashSet<Coordinate>();
        private HashSet<Coordinate> _walls = new HashSet<Coordinate>();

        Robot _robot;

        public void CleanRoom(Robot robot)
        {
            _robot = robot;

            Coordinate wall, curPos = new Coordinate(1, 3), initialPos = curPos;
            VisitCell(initialPos);

            Direction curDir = Direction.Up;
            Direction newDir;

            while (!RobotFinished(initialPos, curPos))
            {
                newDir = ChooseDirection(curPos);
                if (newDir == Direction.NoWay)
                    return;
                //Console.WriteLine($"Robot decided to go {newDir}");

                TurnRobot(curDir, newDir);
                curDir = newDir;

                if (_robot.Move())
                {
                    curPos = GetNextPosition(curPos, curDir);
                    VisitCell(curPos);
                }
                else
                {
                    wall = GetNextPosition(curPos, curDir);

                    _walls.Add(wall);
                }
            }
        }

        private bool RobotFinished(Coordinate initialPos, Coordinate curPos)
        {
            // workaround: stop when we visit initial position for too many times
            int initVisits = GetVisitedNumber(initialPos);
            return initVisits > 50;

            //int visitedUp, visitedDown, visitedLeft, visitedRight;

            //if (curPos.Equals(initialPos))
            //{
            //    CheckNeighbourCells(initialPos, out visitedUp, out visitedDown, out visitedLeft, out visitedRight);
            //    return (visitedUp != 0 && visitedDown != 0 && visitedLeft != 0 && visitedRight != 0);
            //}

            //return false;
        }

        private void TurnRobot(Direction curDir, Direction newDir)
        {
            if (curDir == newDir) return;

            if (Math.Abs(curDir - newDir) == 2)
            {
                _robot.TurnLeft();
                _robot.TurnLeft();
                //Console.WriteLine("Rotating robot twice");
                return;
            }

            if (curDir == Direction.Up)
            {
                if (newDir == Direction.Right)
                    TurnRight();
                if (newDir == Direction.Left)
                    TurnLeft();
                return;
            }

            if (curDir == Direction.Right)
            {
                if (newDir == Direction.Down)
                    TurnRight();
                if (newDir == Direction.Up)
                    TurnLeft();
                return;
            }

            if (curDir == Direction.Down)
            {
                if (newDir == Direction.Right)
                    TurnLeft();
                if (newDir == Direction.Left)
                    TurnRight();
                return;
            }

            if (curDir == Direction.Left)
            {
                if (newDir == Direction.Up)
                    TurnRight();
                if (newDir == Direction.Down)
                    TurnLeft();
                return;
            }
        }

        private void TurnRight()
        {
            //Console.WriteLine("Rotating robot right");
            _robot.TurnRight();
        }

        private void TurnLeft()
        {
            //Console.WriteLine("Rotating robot left");
            _robot.TurnLeft();
        }

        private Direction ChooseDirection(Coordinate curPos)
        {
            int visitedUp, visitedDown, visitedLeft, visitedRight;
            CheckNeighbourCells(curPos, out visitedUp, out visitedDown, out visitedLeft, out visitedRight);

            List<int> visits = CalculateVisits(visitedUp, visitedDown, visitedLeft, visitedRight);
            if (visits.Count == 0)
                return Direction.NoWay;
            int minVisited = visits.Min();

            return ChooseDirection(visitedUp, visitedDown, visitedLeft, visitedRight, minVisited);
        }

        private void CheckNeighbourCells(Coordinate curPos, out int visitedUp, out int visitedDown, out int visitedLeft, out int visitedRight)
        {
            var nextUp = GetNextPosition(curPos, Direction.Up);
            var nextDown = GetNextPosition(curPos, Direction.Down);
            var nextLeft = GetNextPosition(curPos, Direction.Left);
            var nextRight = GetNextPosition(curPos, Direction.Right);

            visitedUp = !_walls.Contains(nextUp) ? GetVisitedNumber(nextUp) : -1;
            visitedDown = !_walls.Contains(nextDown) ? GetVisitedNumber(nextDown) : -1;
            visitedLeft = !_walls.Contains(nextLeft) ? GetVisitedNumber(nextLeft) : -1;
            visitedRight = !_walls.Contains(nextRight) ? GetVisitedNumber(nextRight) : -1;
        }

        private Direction ChooseDirection(
            int visitedUp, int visitedDown, int visitedLeft, int visitedRight, int minVisited)
        {
            Direction direction = Direction.Up;
            if (visitedUp == minVisited)
                direction = Direction.Up;
            else if (visitedDown == minVisited)
                direction = Direction.Down;
            else if (visitedLeft == minVisited)
                direction = Direction.Left;
            else if (visitedRight == minVisited)
                direction = Direction.Right;
            else
                throw new Exception("Couldn't choose direction!!!");

            return direction;
        }

        private List<int> CalculateVisits(int visitedUp, int visitedDown, int visitedLeft, int visitedRight)
        {
            var visits = new List<int>();
            if (visitedUp >= 0) visits.Add(visitedUp);
            if (visitedDown >= 0) visits.Add(visitedDown);
            if (visitedLeft >= 0) visits.Add(visitedLeft);
            if (visitedRight >= 0) visits.Add(visitedRight);
            return visits;
        }

        private int GetVisitedNumber(Coordinate next)
        {
            if (_visitedCells.ContainsKey(next))
                return _visitedCells[next];

            return 0;
        }

        private Coordinate GetNextPosition(Coordinate curPos, Direction curDir)
        {
            switch (curDir)
            {
                case Direction.Up:
                    curPos.Row--;
                    break;
                case Direction.Down:
                    curPos.Row++;
                    break;
                case Direction.Left:
                    curPos.Column--;
                    break;
                case Direction.Right:
                    curPos.Column++;
                    break;
            }

            return curPos;
        }

        private void VisitCell(Coordinate cell)
        {
            if (!_visitedCells.ContainsKey(cell))
                _visitedCells.Add(cell, 1);
            else
                _visitedCells[cell]++;

            CleanCell(cell);
        }

        private void CleanCell(Coordinate cell)
        {
            if (!_cleanedCells.Contains(cell))
            {
                _robot.Clean();
                _cleanedCells.Add(cell);
            }
        }
    }
}
