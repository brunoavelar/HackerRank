using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class CompareTriplets
    {
        public static int[] Execute(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int aPoints = 0;
            int bPoints = 0;

            if(a0 > b0)
            {
                aPoints++;
            }else if (a0 < b0)
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
    }
}
