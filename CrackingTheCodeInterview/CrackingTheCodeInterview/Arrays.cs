using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodeInterview
{
    public static class Arrays
    {
        public static int[] ShiftLeft(int[] array, int times)
        {
            var rotatedArray = new int[array.Length];
            int lenthOfSourceToCopy = array.Length - times;

            Array.ConstrainedCopy(array, times, rotatedArray, 0, lenthOfSourceToCopy);
            Array.ConstrainedCopy(array, 0, rotatedArray, lenthOfSourceToCopy, times);

            return rotatedArray;
        }
    }
}
