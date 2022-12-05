using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_twelve_parameterized_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            C e = new C(3, 9, 12);

            Console.ReadLine();
        }
        class A
        {
            public A(int x)
            {
                Console.WriteLine("Class A = " + x);

            }
        }
        class B:A 
        {
            public B(int a,int b):base(a)
            {
                Console.WriteLine(" Class B = " + a +  b);
            }
        
        }
        class C:B
        {
            public C(int p,int s,int r):base(p,s)
            {
                Console.WriteLine("  Class C = " +  p   +   s   +   r);

            }
        }
    }
}
