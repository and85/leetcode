using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        private class Vertex
        {
            public Vertex(int row, int column)
            {
                Row = row;
                Column = column;
            }

            public int Row { get; set; }
            public int Column { get; set; }

            public bool IsVisited { get; set; }
        }

        public int CountServers(int[][] grid)
        {
            var rows = new Dictionary<int, int>();
            var columns = new Dictionary<int, int>();
            var vertexes = new List<Vertex>();

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                { 
                    if (grid[r][c] == 1)
                    {
                        PopulateEntranceDictionary(rows, r);
                        PopulateEntranceDictionary(columns, c);

                        vertexes.Add(new Vertex(r, c));
                    }
                }
            }

            foreach(Vertex v in vertexes)
            {
                if (rows.ContainsKey(v.Row) && rows[v.Row] > 1)
                    v.IsVisited = true;
                if (!v.IsVisited && columns.ContainsKey(v.Column) && columns[v.Column] > 1)
                    v.IsVisited = true;
            }

            return vertexes.Count(v => v.IsVisited);
        }

        private void PopulateEntranceDictionary(Dictionary<int, int> entrance, int index)
        {
            if (entrance.ContainsKey(index))
                entrance[index]++;
            else
                entrance.Add(index, 1);
        }
    }
}
