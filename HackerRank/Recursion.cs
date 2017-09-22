using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodeInterview
{
    public static class Recursion
    {
        public static int Fibonacci(int number)
        {
            if(number == 0)
            {
                return 0;
            }

            if (number == 1)
            {
                return 1;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
