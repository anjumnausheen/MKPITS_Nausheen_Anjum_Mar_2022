using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_r
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
          Demo d1=new Demo();

            Derived d2=new Derived();


            Console.ReadLine();


            
          
        }
    }

    class Demo
    {
        public void show()
        {
            Console.WriteLine("Demo show");
        }
    }
    class Derived:Demo
    {
        public void disp()
        {
            Console.WriteLine("Display show");
        }
    }
    
    
          
}
