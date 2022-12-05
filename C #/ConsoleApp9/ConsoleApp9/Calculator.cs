using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Calculator
    {
        int x, y;

        public Calculator()
        {
            x = 0; y = 0;
        }
        public Calculator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Calculator Operator + (Calculator op2,Calculator op3)
        {
            op1.x=op2.x+op3.x;
            op1.y=op2.y+op3.y;
            return op1;
        }
    public static show()
    {
        Console.WriteLine(" x = " + x + " y =" + y);
    }

    }
}
