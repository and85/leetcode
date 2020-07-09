using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Solution
    {
        struct Coordinate: IEquatable<Coordinate>
        {
            public int X { get; set; }
            public int Y { get; set; }

            public bool Equals(Coordinate other) =>
                (X, Y).Equals((other.X, other.Y));

            public override int GetHashCode() =>
                (X, Y).GetHashCode();
        }


        public bool IsPathCrossing(string path)
        {
            var visitedCoordinates = new HashSet<Coordinate>();

            var currCoordinate = new Coordinate { X = 0, Y = 0 };            
            visitedCoordinates.Add(currCoordinate);

            for (int i = 0; i < path.Length; i++)
            {
                currCoordinate = MakeMove(path[i], currCoordinate);

                if (visitedCoordinates.Contains(currCoordinate))
                    return true;
                else
                    visitedCoordinates.Add(currCoordinate);
            }

            return false;
        }

        private Coordinate MakeMove(char move, Coordinate currCoordinate)
        {
            switch (move)
            {
                case 'N':
                    currCoordinate.Y += 1;
                    break;
                case 'S':
                    currCoordinate.Y -= 1;
                    break;
                case 'E':
                    currCoordinate.X -= 1;
                    break;
                case 'W':
                    currCoordinate.X += 1;
                    break;
            }

            return currCoordinate;
        }
    }
}
