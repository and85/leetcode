using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public struct Pixel
        {
            public Pixel(int row, int column)
            {
                Row = row;
                Column = column;
            }

            public int Row { get; set; }
            public int Column { get; set; }
        }

        public int FindLonelyPixel(char[][] picture)
        {
            int rowNum = picture.Length;
            int colNum = picture[0].Length;
            var rowEntries = new List<Pixel>[rowNum];
            var colEntries = new List<Pixel>[colNum];

            for (int r = 0; r < rowNum; r++)
                for (int c = 0; c < colNum; c++)
                {
                    if (picture[r][c] == 'B')
                    {
                        if (rowEntries[r] == null)
                            rowEntries[r] = new List<Pixel>();
                        if (colEntries[c] == null)
                            colEntries[c] = new List<Pixel>();


                        rowEntries[r].Add(new Pixel(r, c));
                        colEntries[c].Add(new Pixel(r, c));
                    }
                }

            var rowList = rowEntries.Where(e => e?.Count == 1).Select(r => r[0]);
            var colList = colEntries.Where(e => e?.Count == 1).Select(c => c[0]);

            int count = rowList.Count(r =>
                colList.Any(c => c.Row == r.Row
                    && c.Column == r.Column));

            return count;
        }
    }
}
