using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_over_asmd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is addition overloading:");
            Addition  o1 = new Addition();

            Addition o2 = new Addition(20,10);

            Addition o3 = new Addition(10, 5);

                o1.show();

                o2.show();

                o3.show();

            o1 = o2 + o3;
            o1.show();

           
            Console.WriteLine(" This is subtraction overloading:");



            Subtraction c1 = new Subtraction();

            Subtraction c2 = new Subtraction(40,20);

            Subtraction c3 = new Subtraction(30,10);

            c1.show();

            c2.show();

            c3.show();

            c1 = c2 - c3;
            c1.show();

            Console.WriteLine("This is Multiplication overloading:");

            Multiplication v1 = new Multiplication();

            Multiplication v2 = new Multiplication(10,10);

            Multiplication v3=new Multiplication(20,10);

            v1.show();

            v2.show();

            v3.show();

            v1 = v2 * v3;
            v1.show();


            Console.WriteLine("This is Division overloading:");

            Division i1=new Division();

            Division i2=new Division(60,10);

            Division i3=new Division(20,10);

            i1.show();

            i2.show();

            i3.show();

            i1 = i2 /i3;

            i1.show();

           Console.ReadLine();
        }
    }
}
