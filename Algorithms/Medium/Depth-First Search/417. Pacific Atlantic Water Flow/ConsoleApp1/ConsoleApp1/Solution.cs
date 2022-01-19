using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {

        private int[][] _heights;
        private int _height;
        private int _width;

        private int[][] _neighborDirections = new int[][]
        {
            new int[] { -1, 0 },
            new int[] { 1, 0 },
            new int[] { 0, -1 },
            new int[] { 0, 1 },
        };

        class Cell: IEquatable<Cell>
        {
            private int _width;

            public Cell(int row, int column, int width)
            {
                Row = row;
                Column = column;
                _width = width;
            }

            public int Row { get; set; }
            public int Column { get; set; }                        

            public override bool Equals(object obj)
            {
                return Equals(obj as Cell);
            }

            public bool Equals(Cell other)
            {
                return other != null &&
                       Row == other.Row &&
                       Column == other.Column;
            }

            public override int GetHashCode()
            {
                return Row * _width + Column;
            }
        }

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            _heights = heights;
            _height = _heights.Length;
            _width = _heights[0].Length;

            var result = new List<IList<int>>();
            
            var pacificReach = PacificReach();            
            var atlanticReach = AtlanticReach();

            var reachTwoOceans = pacificReach.Intersect(atlanticReach);
            foreach (var cell in reachTwoOceans)
            {
                result.Add(new List<int>() { cell.Row, cell.Column });
            }

            return result;
        }

        private HashSet<Cell> AtlanticReach()
        {
            var visited = new HashSet<Cell>();

            for (int r = 0; r < _height; r++)
            {                
                var curCell = new Cell(r, _width - 1, _width);
                Dfs(curCell, visited);
            }

            for (int c = 0; c < _width; c++)
            {                
                var curCell = new Cell(_height - 1, c, _width);
                Dfs(curCell, visited);
            }
                
            return visited;
        }

        private HashSet<Cell> PacificReach()
        {
            var visited = new HashSet<Cell>();
            for (int r = 0; r < _height; r++)
            {
                var curCell = new Cell(r, 0, _width);                                
                Dfs(curCell, visited);                
            }

            for (int c = 0; c < _width; c++)
            {
                var curCell = new Cell(0, c, _width);
                Dfs(curCell, visited);
            }

            return visited;
        }

        private void Dfs(Cell curCell, HashSet<Cell> visited)
        {
            if (visited.Contains(curCell))
                return;

            visited.Add(curCell);

            foreach (var direction in _neighborDirections)
            {
                var neighbor = new Cell(curCell.Row + direction[0], curCell.Column + direction[1], _width);
                if (IsCellOutOfRange(neighbor))
                    continue;

                if (_heights[curCell.Row][curCell.Column] <= _heights[neighbor.Row][neighbor.Column])
                {                    
                    Dfs(neighbor, visited);
                }
            }
        }

        private bool IsCellOutOfRange(Cell curCell)
        {
            return curCell.Row < 0 || curCell.Row == _height || curCell.Column  < 0 || curCell.Column == _width;
        }
    }
}
