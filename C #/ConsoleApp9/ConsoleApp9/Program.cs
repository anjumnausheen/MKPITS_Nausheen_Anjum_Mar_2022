using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator o1=new Calculator();
            Calculator o2=new Calculator(5,2);
            Calculator o3 = new Calculator(6,3);

            o1.show();
            o2.show();
            o3.show();

            o1 = o2 + o3;

            o1.show();


            Console.ReadLine();  
            
           
        }
    }
}
