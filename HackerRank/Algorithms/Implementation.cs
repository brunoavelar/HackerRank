using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class Implementation
    {
        public static int[] RoundUpGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38)
                {
                    continue;
                }

                var rest = grades[i] % 5;

                if (rest > 2)
                {
                    grades[i] += (5 - rest);
                }
            }

            return grades;
        }

        public static BigInteger ExtraLongFactorial(BigInteger number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * ExtraLongFactorial(number - 1);
        }
    }
}
