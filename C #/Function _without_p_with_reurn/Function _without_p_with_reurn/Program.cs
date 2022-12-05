using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function__without_p_with_reurn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            c = add();
            Console.WriteLine("\tAddition=" + c);
            Console.ReadLine();

        }
        static int add()
        {
            int x, y, z;
            Console.WriteLine("Enter 2 numbers:");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            z = x + y;
            return z;
        }
    }
}
