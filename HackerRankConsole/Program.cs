using System;

namespace HackerRankConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var expected = new[] { "     #", "    ##", "   ###", "  ####", " #####", "######" };

            foreach (var item in expected)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}