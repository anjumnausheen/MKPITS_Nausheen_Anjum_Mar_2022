using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator_overloading o1=new Operator_overloading();

            Operator_overloading o2=new Operator_overloading(10,10);

            Operator_overloading o3 = new Operator_overloading(20,20);

            o1.show();
            o2.show();
            o3.show();

            o1 = o2 + o3;

            o1.show();

            Console.ReadLine();


        }
    }
}
