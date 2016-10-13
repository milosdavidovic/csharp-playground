using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    class TupleClass
    {
        public static void TupleExample()
        {
            Console.WriteLine("### Tuple example ###");
            Tuple<int, string, string>[] tuple;
            tuple = new Tuple<int, string, string>[] {
                new Tuple<int, string, string>(1, "Pera", "Petrovic"),
                new Tuple<int, string, string>(2, "Marko", "Markovic")
            };

            foreach(Tuple<int, string, string> t in tuple)
            {
                PrintTuple3(t);
                
            }
        }

        private static void PrintTuple3(Tuple<int, string, string> t)
        {
            Console.WriteLine("Printing tuple:");
            Console.WriteLine(t.ToString());
        }
    }
}
