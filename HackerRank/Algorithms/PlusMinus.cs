using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class PlusMinus
    {
        public static decimal[] Execute(int[] values)
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
    }
}
