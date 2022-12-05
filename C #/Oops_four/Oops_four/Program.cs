using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_four
{
    internal class Program

    {
        
        static void Main(string[] args)
        {

            Base b= new Base();
            b.show();
            Derived d=new Derived();
            d.show();
            d.disp();

            Console.ReadLine();

        }
        class Base
        {
            public void show()
            {
                Console.WriteLine("\t Base Show");
            }
        }
        class Derived : Base
        {
            public void disp()
            {
                Console.WriteLine("\t Derived Display");
            }
        }
        

    }
}
//inheritance 1 program
