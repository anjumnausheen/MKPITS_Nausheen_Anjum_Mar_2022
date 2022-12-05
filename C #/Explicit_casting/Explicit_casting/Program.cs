using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mydouble = 9.78;
            int myInt = (int) mydouble;
            Console.WriteLine(mydouble);
            Console.WriteLine(myInt);
            Console.ReadLine();

        }
    }
}
