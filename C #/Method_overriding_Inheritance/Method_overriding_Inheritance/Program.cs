using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overriding_Inheritance
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            // FUNCTION WITH SAME NAME AND SAME PARAMETERS BUT IN DIFFERENT CLASS(PARENT CHILD CLASS)
            Demo d = new Demo();
            Demo1 d1 =new Demo1();

           
            /* HERE CHILD WILL CALL ITS OWN SHOW FUNCTION AND NOT PARENT SHOW FUNCTION. THIS IS 
             * BECAUSE CHILD HAS OVERRIDEN ITS PARENT SHOW FUNCTION.
             * THIS PROCESS IS CALLED AS METHOD OVERRIDING
             */ 
            
            d.show();

            d1.show();

            Console.ReadLine();
        }
        
    }

    class Demo
    {
        public void show()
        {
            Console.WriteLine("This is show Function: Demo");
        }
    }
    class Demo1:Demo
    {
        public void show()
        {
            Console.WriteLine("This is show Function: Demo1");
        }
    }
}
