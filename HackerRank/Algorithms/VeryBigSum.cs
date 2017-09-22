using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class VeryBigSum
    {
        public static long Execute(long[] values)
        {
            long result = 0;

            foreach (var value in values)
            {
                result += value;
            }

            return result;
        }
    }
}
