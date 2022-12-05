using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_over_asmd
{
    internal class Subtraction
    {
        int a,b;


        //Simple Constructor
        public Subtraction()
        {
            a = 0;
            b = 0;
        }
       
        //Parameterized Constructor
        public Subtraction(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Subtraction operator - (Subtraction c2,Subtraction c3)
        {
            Subtraction c1=new Subtraction();
            c1.a = c2.a- c3.a;
            c1.b = c2.b- c3.b;

            return c1;
        }

        public void show()
        {
            Console.WriteLine(" a = " + a + " b = " + b);
        }

        


    }
}
