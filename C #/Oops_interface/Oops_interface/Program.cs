using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child ch= new Child();
            ch.disp();
            ch.show();
            ch.myfun();

            Console.ReadLine();

        }
    }
    interface Myinterface
    {
         void disp();
         void show();
    }
    class Child:Myinterface
    {
        public void disp()
        {
            Console.WriteLine("Display Function:");
        }
        public void show()
        {
            Console.WriteLine("Show Function:");
        }
        public void myfun()
        {
            Console.WriteLine("This is my function:");
        }
    }
}
