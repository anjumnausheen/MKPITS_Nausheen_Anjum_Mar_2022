using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_with_p_w_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 numbers:");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            add(x, y);
            Console.ReadLine();
        }
        static void add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("\tAddition= " + c);

        }
    }
}
//function with parameter without return type
