using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_with_parameter_with_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y,z;
            Console.WriteLine("Enter 2 numbers:");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            z = add(x, y);
            Console.WriteLine("\tAddition= " + z);
            Console.ReadLine();
            

        }
        static int  add(int a,int b)
        {
            int c;
            c = a + b;
            return c;
        }
    }
}
