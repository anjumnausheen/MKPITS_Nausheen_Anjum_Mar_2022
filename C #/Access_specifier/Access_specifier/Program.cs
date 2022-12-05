using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_specifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cl = new Calculator();
            Base b=new Base();
            Derived d = new Derived();
            /*b.show();*/
            b.disp();
           /* b.display();*/
            d.myfun();

            Console.ReadLine();
        }
        class Base
        {
            private void show()
            {
                Console.WriteLine("Private Show");
            }
            public void disp()
            {
                Console.WriteLine("Public Display");
            }
            protected void display()
            {
                Console.WriteLine("Protected Display");
            }
        }
            class Derived : Base
            {
                public void myfun()
                {
                    display();
                    Console.WriteLine("Derived Public MyFun");
                }
            }

        }
    }

