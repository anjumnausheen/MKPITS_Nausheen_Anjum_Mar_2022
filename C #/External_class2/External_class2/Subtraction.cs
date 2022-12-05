using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace External_class2
{
    internal class Subtraction
    {
        public void sub()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c = a -b;
            Console.WriteLine("Subtraction = " + c);

        }
    }
}
