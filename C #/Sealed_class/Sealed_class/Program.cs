using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derieved d1 =new Derieved();
            d1.show();
            Console.ReadLine();
        }
       /* Sealed class
        * sealed class Base
        {
            public void disp()
            {
                Console.WriteLine("Public disp");
            }
        }
        class Derived : Base
        {
            public void myfun()
            {            
                Console.WriteLine("Derived Public MyFun");
            }
        }*/


        /*
         * Sealed METHOD         
         */
        class Base
        {
            // VIRTUAL KEYWORD IS USED FOR DYANAMIC BINDING / RUN TIME BINDING 
           public virtual void show()
            {
                Console.WriteLine("This is sealed show function");
            }
        }
        class Derieved : Base
        {
            public sealed override void show()
            {
                Console.WriteLine("This is sealed show function overriding");
            }
        }
        class Derieved2 : Derieved
        {
            public override void show()
            {
                Console.WriteLine("This is show functin");
            }
        }


    }
}
