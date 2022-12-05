using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d=new Demo();
            d.add(3);
            d.add(5, 7);
            d.add(2,6,1);
            Console.ReadLine();

        }
        class Demo
        {
            public void add(int a)
            {
                Console.WriteLine("Addition = "+a);
            }
            public void add(int a,int b)
            {
                int c=a+b;
                Console.WriteLine("Addition  =" + c);
            }
            public void add(int a,int b,int c)
            {
                int d = a + b + c;
                Console.WriteLine("Addition =" + d);
            }
            
        }
    }
}
