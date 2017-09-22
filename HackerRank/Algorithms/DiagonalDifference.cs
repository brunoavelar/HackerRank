using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class DiagonalDifference
    {
        public static int Execute(int[][] values)
        {
            int diagonalA = 0;
            int diagonalB = 0;

            for (int r = 0; r <= values.GetLength(0) - 1; r++)
            {
                var diagonalValueA = values[r][r];
                diagonalA += diagonalValueA;

                var length = values[r].Length - 1;
                var index = length - r;
                var diagonalValueB = values[r][index];
                diagonalB += diagonalValueB;
            }

            return Math.Abs(diagonalA - diagonalB);
        }
    }
}

