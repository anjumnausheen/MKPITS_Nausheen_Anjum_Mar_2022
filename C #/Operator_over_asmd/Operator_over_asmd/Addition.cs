using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_over_asmd
{
    internal class Addition
    {
        int x, y;
        // simple constructor
        public Addition()
           {
            x=0;
            y=0;
            }
       // Parameterized Constructor 
        
        public Addition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Addition operator + (Addition op2,Addition op3)
        {
             Addition op1=new Addition();
            op1.x=op2.x+op3.x;
            op1.y=op2.y+op3.y;
            return op1;
        }


        public void show()
        {
            Console.WriteLine(" x =  " + x   + "  y = " +  y);
        }

       

        

    }
}
