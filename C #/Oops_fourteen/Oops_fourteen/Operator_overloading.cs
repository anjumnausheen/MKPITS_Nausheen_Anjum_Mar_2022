using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_fourteen
{
   class Operator_overloading
    {
        int x, y;
        // SIMPLE CONSTRUCTOR
        public Operator_overloading()
        {
            x = 0;
            y = 0;
        }
        // PARAMETERIZED CONSTRUCTOR
        public Operator_overloading(int x, int y)
        {
            this.x = x; 
            this.y = y;
        }
        public static Operator_overloading operator + (Operator_overloading op2, Operator_overloading op3)
        {
            Operator_overloading op1 = new Operator_overloading();
            op1.x = op2.x + op3.x;
            op1.y = op2.y + op3.y;
            return op1;
        }
        public void show()
        {
            Console.WriteLine(" x  = " + x + " y = " + y);
        }
    }
}
