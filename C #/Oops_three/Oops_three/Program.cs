using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_three
{
    internal class Program
    {
        static void Main(string[] args)
        {

        

            calculator calc1=new calculator();

            calc1.getdata(20,10);

            calc1.adddata();

            calc1.subdata();

            calc1.muldata();

            calc1.divdata();

            Console.ReadLine();
       
           
           
      
        }

        class calculator
        {
            int x, y;

            public void getdata(int a,int b)
            {
                x = a;
                y = b;
            }
            public void adddata( )
            {
                 int c=x+y;
                Console.WriteLine(" ADDITION IS "+ c);
            }
            public void subdata( )
            {
                int d=x-y;
                Console.WriteLine(" SUBTRACTION IS "+ d);
            }
            public void muldata( )
            {
               int e=x*y;
                Console.WriteLine(" MULTIPLICATION IS "+ e);


            }
            public void divdata( )
            {
                int f=x/y;
                Console.WriteLine(" DIVISION IS " + f);
            }
            

        }

    }
}
