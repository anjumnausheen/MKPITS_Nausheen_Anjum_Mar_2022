using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_parameter_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod("Sweden");
            MyMethod("India");
            MyMethod();
            MyMethod("USA");
            Console.ReadLine();
        }
       static void MyMethod(string country="Norway")
        {
            Console.WriteLine(country);
        }

    }
}
