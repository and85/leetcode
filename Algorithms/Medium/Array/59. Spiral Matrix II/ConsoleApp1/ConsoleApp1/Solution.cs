using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        private int _minR;
        private int _minC;
        private int _maxR;
        private int _maxC;
        private (int, int)[] _directions = new (int, int)[4] { (0, 1), (1, 0), (0, -1), (-1, 0) };

        public int[][] GenerateMatrix(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            

            _minR = 0;
            _minC = 0;
            _maxR = n - 1;
            _maxC = n - 1;            

            int d = 0, p = 0;
            int r = 0, c = -1;
            
            while (p < n * n)
            {
                r += _directions[d].Item1;
                c += _directions[d].Item2;

                result[r][c] = ++p;

                if (!IsInRange(r, c, d))
                {                        
                    
                    switch (d)
                    {
                        case 0:
                        {
                           _maxC--;
                            break;
                        }
                        case 1:
                        {
                            _maxR--;
                            break;
                        }
                        case 2:
                        {
                           _minR++;
                            break;
                        }
                        case 3:
                        {
                            _minC++;
                            break;
                        }
                    }


                    d = ++d % 4;
                    continue;
                }                  
                
                
            }


            return result;
        }

        private bool IsInRange(int r, int c, int d)
        {
            int nr = r + _directions[d].Item1;
            int nc = c + _directions[d].Item2;

            switch (d)
            {
                case 0:
                {
                    return nc <= _maxC;                    
                }
                case 1:
                {
                    return nr <= _maxR;
                }
                case 2:
                {
                    return nc >= _minC;
                }
                case 3:
                {
                    return nr >= _minR;
                }
            }

            return false;

        }
    }
}
