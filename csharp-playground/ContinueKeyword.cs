using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    class ContinueKeyword
    {
        private int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void PrintOddsUsingContinue()
        {
            Console.WriteLine("### Demonstrating continue keyword ###");
            for (int i = 0; i < 10; i++)
            {
                if((i%2 == 0))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
