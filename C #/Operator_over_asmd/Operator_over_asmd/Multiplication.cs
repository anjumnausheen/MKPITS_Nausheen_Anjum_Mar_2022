using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_over_asmd
{
    internal class Multiplication
    {
        int m, n;

        // simple constructor
        public  Multiplication()
            {
            m=0;

            n=0;

            }


    //Parameterized Constructor

    public  Multiplication(int m, int n)
             {
                this.m=m;
                this.n=n;

             }
    public static Multiplication operator *(Multiplication v2,Multiplication v3)
    {
        Multiplication v1 = new Multiplication();
        v1.m = v2.m * v3.m;
        v1.n = v2.n * v3.n;

        return v1;
    }

    public void show()
    {
        Console.WriteLine(" m =" + m + " n=" + n);
    }


    }
}
