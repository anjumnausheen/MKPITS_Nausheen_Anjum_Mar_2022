using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_nine_parameterized_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo(3,4);
            Demo d2 = new Demo(7,2);

            Console.ReadLine();

        }
        class Demo
        {
            public Demo(int x,int y)
            {
                Console.WriteLine("Demo constructor called x= " + x + "  y=" + y);
            }
        }
    }
}
