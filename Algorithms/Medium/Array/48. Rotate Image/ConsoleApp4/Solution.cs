using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int layersNumber = matrix.Length / 2;

            for (int layerNumber = 0; layerNumber < layersNumber; layerNumber++)
            {
                RotateLayer(matrix, layerNumber);
            }
        }

        private void RotateLayer(int[][] matrix, int layerNumber)
        {
            int first = layerNumber;
            int last = matrix.Length - layerNumber - 1;

            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                int temp = matrix[first][i];

                matrix[first][i] = matrix[last - offset][first];
                matrix[last - offset][first] = matrix[last][last - offset];
                matrix[last][last - offset] = matrix[i][last];
                matrix[i][last] = temp;
            }
        }
    }
}
