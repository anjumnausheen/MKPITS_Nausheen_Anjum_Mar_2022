using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overloading_4_in_1_class
{
    internal class Calculator
    {
        int x, y;
        //Simple Constructor
        public Calculator()
        {
            x = 0;
            y = 0;
        }

        //Parameterized Constructor
        public Calculator(int x, int y )        {
            this.x = x;
            this.y = y;
        }

        
        public static Calculator operator +(Calculator o2,Calculator o3)
        {
            Calculator o1= new Calculator();
            
            o1.x= o2.x + o3.x;
            o1.y= o2.y + o3.y;
            return o1;
        }

        public static Calculator operator -(Calculator o2, Calculator o3)
        {
            Calculator o1 = new Calculator();

            o1.x = o2.x - o3.x;
            o1.y = o2.y - o3.y;

            return o1;
        }

        public static Calculator operator * (Calculator o2,Calculator o3)
        {
            Calculator o1=new Calculator();

            o1.x=o2.x * o3.x;
            o1.y=o2.y * o3.y;
            return o1;
        }
        public static Calculator operator /(Calculator o2,Calculator o3)
        {
            Calculator o1 = new Calculator();

            o1.x=o2.x / o3.x;
            o1.y = o2.y / o3.y;
            return o1;
        }

            public void show()
        {
            Console.WriteLine("x = "+x+" y = " +y);
        }
    }
}
