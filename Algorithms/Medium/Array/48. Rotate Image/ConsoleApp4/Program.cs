using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[][] matrix = new int[][]
            {
                new int[] { 5, 1, 9, 11 },
                new int[] { 2, 4, 8, 10 },
                new int[] { 13, 3, 6, 7 },
                new int[] { 15,14,12,16 }
            };

            PrintMatrix(matrix);

            solution.Rotate(matrix);

            Console.WriteLine("--------------------------");
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
