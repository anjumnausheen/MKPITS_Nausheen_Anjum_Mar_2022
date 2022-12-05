using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_seven_Hirarchical_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t = Base Class:");

            Base b=new Base();
            b.show();

            Console.WriteLine("\t = Derivedb Display:");
            Derivedb c=new Derivedb();
            c.show();
            c.dis();

            Console.WriteLine("\t = Derivedd alpha:");
            Derivedd d=new Derivedd();
            d.show();
            d.dis();
            d.alpha();

            Console.WriteLine("\t = Derivede cir:");
            Derivede e=new Derivede();
            e.show();
            
            e.dis();
            e.cir();

            Console.WriteLine("\t = Derivedc tri:");
            Derivedc f=new Derivedc();
            f.tri();
            f.show();

            Console.WriteLine("\t = Derivedf rec:");
            Derivedf g=new Derivedf();
            g.show();
            g.tri();
            g.rec();

            Console.WriteLine("\t = Derivedg square:");
            Derivedg h=new Derivedg();
            h.show();
            h.tri();
            h.square();

            Console.ReadLine();
        }
        class Base
        {
        
            public void show()
            {
                Console.WriteLine("Base show");
            }
        }
        class Derivedb:Base
        {

            public void dis()
            {
                Console.WriteLine("Derivedb Display");
            }
        }
        class Derivedd:Derivedb
        {
            public void alpha()
            {
                Console.WriteLine("Derivedd alpha");
            }
        }
        class Derivede:Derivedb
        {
            public void cir()
            {
                Console.WriteLine("Derived cir");
            }
        }
        class Derivedc : Base
        { 
            public void tri()
            {
                Console.WriteLine("Derived triangle");
            }
        }
        class Derivedf:Derivedc
        {
            public void rec()
            {
                Console.WriteLine("Derived rectangle");
            }
        }
        class Derivedg:Derivedc
        {
            public void square()
            {
                Console.WriteLine("Derived square");
            }
        }


    }
}
