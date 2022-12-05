using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Abstract_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Demo d = new Demo();

            Demo1 d1=new Demo1();
            d1.display();
            d1.show();

            Console.ReadLine();
        }

    }
   abstract class Demo
    {
        public void show()
        {
            Console.WriteLine("This is show Function:");
        }
    }
    class Demo1 : Demo
    {
        public void display()
        {
            Console.WriteLine("This is Display Function:");
        }
        
 
    }
}
