using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground
{
    class TypeOf
    {
        public static void TypeOfExample()
        {
            //typeof returns Type object
            Type tip = typeof(string);
            Console.WriteLine("### typeof example ###");
            Console.WriteLine("Name: {0}", tip.Name);
            Console.WriteLine("FullName: {0}", tip.FullName);
            Console.WriteLine("Namespace: {0}", tip.Namespace);
            //Use "is" keyword to check object type
            if ("string" is string)
            {
                Console.WriteLine("String check sucessfull");
            }
            //Use "typeof" keyword and GetType method to check object type
            if ("string".GetType() == typeof(string))
            {
                Console.WriteLine("String check sucessfull");
            }
        }
    }
}
