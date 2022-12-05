using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_fourteen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Demo d =new Demo();
            d.add(3);
            d.add(5, 7);
            d.add(2, 6, 1);*/




            // OPERATOR OVERLOADING EXAMPLE
            Operator_overloading o1 = new Operator_overloading();
            Operator_overloading o2 = new Operator_overloading(5, 2);
            Operator_overloading o3 = new Operator_overloading(6, 3);
            o1.show();
            o2.show();
            o3.show();
            o1 = o2 + o3;
            o1.show();


            Console.ReadLine();
        }


        class Demo
        {

            public void add(int a)
            {
                Console.WriteLine("Addition = " + a);
            }


            public void add(int a, int b)
            {
                int c = a + b;
                Console.WriteLine("Addition = " + c);
            }



            public void add(int a, int b, int c)
            {
                int d = a + b + c;
                Console.WriteLine("Addition=" + d);
            }
        }


    }
}
