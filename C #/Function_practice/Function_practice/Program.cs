using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add();
            Console.ReadLine();
        }

            static void add()
            {

                int a, b, c;
                Console.WriteLine("Enter 2 numbers:");
                a=Convert.ToInt32(Console.ReadLine());
                b=Convert.ToInt32(Console.ReadLine());
                c = a + b;
                Console.WriteLine("\tAddition= " + c);

        }
    }
}
