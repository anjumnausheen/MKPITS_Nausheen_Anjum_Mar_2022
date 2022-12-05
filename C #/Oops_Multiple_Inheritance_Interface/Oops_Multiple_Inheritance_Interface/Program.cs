using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Multiple_Inheritance_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Child ch =new Child();

            ch.disp();
            ch.show();
            ch.myfun();
            ch.hello();

            Console.ReadLine();
        }
    }
    interface Myinterface
    {
         void disp();
         void show();
    }
    interface Inter2
    {
        void myfun();
    }
    class Child : Myinterface, Inter2
    {
       public void disp()
        {
            Console.WriteLine("This is Display Function:");

        }
       public void show()
        {
            Console.WriteLine("This is Show Function:");
        }
       public void myfun()
        {
            Console.WriteLine("This is MyFunction:");

        }
        public void hello()
        {
            Console.WriteLine("This is hello Function:");
        }
    }

}
