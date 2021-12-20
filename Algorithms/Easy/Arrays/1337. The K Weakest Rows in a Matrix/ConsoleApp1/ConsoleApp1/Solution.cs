using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public class Solution
        {
            class Row
            {
                public int Index { get; set; }
                public int Power { get; set; }
            }


            public int[] KWeakestRows(int[][] mat, int k)
            {                
                var positions = new LinkedList<Row>();
                for (int r = 0; r < mat.Length; r++)
                {
                    int p = 0;
                    for (int c = 0; c < mat[r].Length; c++)
                    {
                        if (mat[r][c] == 1)
                            p++;
                        else
                            break;
                    }
                    var row = new Row { Index = r, Power = p };               

                    UpdatePositions(positions, row, k);
                }

                return positions.Select(p => p.Index).ToArray();
            }

            private void UpdatePositions(LinkedList<Row> rows, Row newRow, int k)
            {
                Row row = null;                
                foreach (var r in rows)
                {
                    // new row is weeker
                    if (r.Power > newRow.Power)
                    {
                        row = r;
                        break;
                    } 
                }

                if (row != null)
                    rows.AddBefore(rows.Find(row), newRow);            
                else
                    rows.AddLast(newRow);

                if (rows.Count > k)
                    rows.RemoveLast();
            }
        }
}
