using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x=3 , y=4 ;

            x = x + y;
            x += y;
            Console.WriteLine("x=" +x + " y="+y);

            x = x - y;
            x -= y;
            Console.WriteLine("x=" +x  +  " y=" +y);

            x = x * y;
            x *= y;
            Console.WriteLine("x=" +x + " y="  +y);

            x = x / y;
            x /= y;
            Console.WriteLine("x=" + x + " y="  +y);

            x = x % y;
            x %= y;
            Console.WriteLine("x=" + x + " y=" + y);

            Console.ReadLine();








        }
    }
}
