using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class Warmup
    {
        public static long VeryBigSum(long[] values)
        {
            long result = 0;

            foreach (var value in values)
            {
                result += value;
            }

            return result;
        }

        public static string[] Staircase(int steps)
        {
            var result = new string[steps];

            for (int i = 1; i <= steps; i++)
            {
                string spaces = string.Empty.PadLeft(steps - i, ' ');
                string sharps = string.Empty.PadLeft(i, '#');
                result[i - 1] = string.Format($"{spaces}{sharps}");

            }
            return result;
        }

        public static decimal[] PlusMinus(int[] values)
        {
            var result = new decimal[3];

            var positives = values.Count(x => x > 0);
            var negatives = values.Count(x => x < 0);
            var zeros = values.Count(x => x == 0);

            result[0] = Decimal.Divide(positives, values.Length);
            result[1] = Decimal.Divide(negatives, values.Length);
            result[2] = Decimal.Divide(zeros, values.Length);

            result[0] = Math.Round(result[0], 6);
            result[1] = Math.Round(result[1], 6);
            result[2] = Math.Round(result[2], 6);

            return result;
        }

        public static int DiagonalDifference(int[][] values)
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

        public static int[] CompareTriplets(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int aPoints = 0;
            int bPoints = 0;

            if (a0 > b0)
            {
                aPoints++;
            }
            else if (a0 < b0)
            {
                bPoints++;
            }

            if (a1 > b1)
            {
                aPoints++;
            }
            else if (a1 < b1)
            {
                bPoints++;
            }

            if (a2 > b2)
            {
                aPoints++;
            }
            else if (a2 < b2)
            {
                bPoints++;
            }

            return new[] { aPoints, bPoints };
        }

        public static string TimeConversion(string time)
        {
            var datetime = DateTime.Parse(time);
            return datetime.ToString("HH:mm:ss");
        }
    }
}
