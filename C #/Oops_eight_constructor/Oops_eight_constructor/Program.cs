using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_eight_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d=new Demo();
            Console.ReadLine();

        }


        class Demo
        {
            public Demo()
            {
                Console.WriteLine("Demo constructor called:");
            }
        }
    }
}
//simple Constructor
