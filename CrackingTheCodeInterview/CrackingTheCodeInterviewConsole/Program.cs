using CrackingTheCodeInterview;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodeInterviewConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var staircase = 3;

            var staircasesWays = Recursion.Staircase(staircase);

            Console.WriteLine(staircasesWays);
            Console.ReadKey();
        }
    }
}
