using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_eleven_parameterized_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child b = new Child(3, 9);
            Console.ReadLine();

        }
        class Demo
        {
            public Demo(int x)
            {
                Console.WriteLine("Class  Demo x= " + x);
            }
        }
        class Child : Demo
        {
            public Child(int a, int b) : base(a)
            {
                Console.WriteLine("a= " + a + " b= " + b);
            }
        }
    }
}
