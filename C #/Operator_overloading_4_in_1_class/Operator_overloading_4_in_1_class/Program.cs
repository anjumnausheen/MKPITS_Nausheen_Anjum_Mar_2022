using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading_4_in_1_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator o1=new Calculator();
            Calculator o2=new Calculator(40,20);
            Calculator o3=new Calculator(20,10);

            o1.show();
            o2.show();
            o3.show();

            Console.WriteLine("This is Addition Operator overloading:");

            o1 = o2 + o3;
            o1.show();

            Console.WriteLine("This is Subtraction Operator overloading:");

            o1 =o2- o3;
            o1.show();

            Console.WriteLine("This is Multiplication Operator overloading:");

            o1 = o2 * o3;
            o1.show();

            Console.WriteLine("This is Division Operator overloading:");

            o1 = o2 / o3;
            o1.show();

            Console.ReadLine();
                

        }
    }
}
