using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_six_inheritance_Multiple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t= Base class:");

            Base b=new Base();
            b.show();
           
            Console.WriteLine("\t = Derived class of Base class:");

            Derived d=new Derived();
            d.show();
            d.dis();
           
            Console.WriteLine("\t = Derived1 class of Base class:");

            Derived1 e=new Derived1();
            e.show();
            e.alpha();

            Console.ReadLine();

        }

        class Base
        {
            public void show()
            {
                Console.WriteLine("Base Show");
            }
        }
        class Derived:Base
        {
            public void dis()
            {
                Console.WriteLine("Derived Display");
            }
        }
        class Derived1:Base
        {
            public void alpha()
            {
                Console.WriteLine("Derived1 Alpha");
            }
        }

    }
}
