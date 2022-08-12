using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b;
            Console.WriteLine("enter length");
            l = Convert.ToInt32(Console.ReadLine()); //toint32 method will convert string to integer
            Console.WriteLine("enter breadth");
            b = Convert.ToInt32(Console.ReadLine());
            int result = l * b;
            Console.WriteLine("Area of Rectangle=" + result);
            Console.ReadLine();
        }
    }
}
