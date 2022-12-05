using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_ten_single_inheritance_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo1 d=new Demo1();
            Console.ReadLine();
        }


        class Demo
        {
            public Demo()
            {
                Console.WriteLine("Demo constructor called:");
            }

        }
        class Demo1:Demo
        {
            public Demo1()
            {
                Console.WriteLine("Demo1 Constuctor called:");
            }
        }
    }
}
//simple constructor
