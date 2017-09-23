using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    public static class Staircase
    {
        public static string[] Execute(int steps)
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
    }
}
