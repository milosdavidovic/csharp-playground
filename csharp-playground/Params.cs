using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    class Params
    {

        public static void ParamsExample()
        {
            Console.WriteLine("### Params keyword example ###");
            PrintParamsTypeNames("Newton", 3, new Tuple<int,string>(1,""));
        }

        private static void PrintParamsTypeNames(params object[] input)
        {

            foreach(object o in input)
            {
                Console.WriteLine("Type name: {0}", o.GetType().Name);
            }
        }
    }
}
