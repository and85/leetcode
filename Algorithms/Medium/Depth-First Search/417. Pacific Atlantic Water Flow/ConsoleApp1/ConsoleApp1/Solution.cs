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
        private int _m;
        private int _n;

        enum CanReachOcean
        {
            No = 0,
            Yes = 1,
            Undefined = 2
        }

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

            public CanReachOcean CanReachPacific { get; set; } = CanReachOcean.Undefined;
            public CanReachOcean CanReachAtlantic { get; set; } = CanReachOcean.Undefined;

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
            _m = _heights.Length;
            _n = _heights[0].Length;

            var result = new List<IList<int>>();
            
            // go by a spiral from border cells which already can reach at least one ocean and
            // and check what cells they can impact

            return result;
        }

        private bool CanReachPacific(int r, int c)
        {
           if (r == 0 || c == 0) 
                return true;

            if (r == _m || c == _n)
                return false;

            return false;
        }

        private bool CanReachAtlantic(int r, int c)
        {
            if (r == _m || c == _n - 1) 
                return true;            

            return false;
        }
    }
}
