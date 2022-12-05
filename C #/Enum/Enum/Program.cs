using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            Base b2 = new Base();

            b1.show();
            b2.show();

             // Console.ReadLine();

        }
    }
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base constructor");
        }
        ~Base()
        {
            Console.WriteLine("Destructor called");
        }
        public void show()
        {
            Console.WriteLine("Show function called");
        }
    }
}
