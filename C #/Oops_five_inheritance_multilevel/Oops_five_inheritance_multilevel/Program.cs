using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_five_inheritance_multilevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b= new Base();
            b.show();
            Console.WriteLine();

           Derived d= new Derived();
            d.show();
            d.dis();
            Console.WriteLine();

            Derived2 a = new Derived2();
            a.show();
            a.dis();
            a.alpha();

            Console.ReadLine();
        }

        class Base
        {
            public void show()
            {
                Console.WriteLine("\t Base show");
            }
        }
        class Derived :Base
        {
            public void dis()
            {
                Console.WriteLine("\t Derived Display");
            }
        }

        class Derived2:Derived
        {
            public void alpha()
            {
                Console.WriteLine("\t Derived 2 alpha");
            }
        }

        
    }
}
