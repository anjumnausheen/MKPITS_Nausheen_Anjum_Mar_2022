using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
             Console.WriteLine("Enter any number:");
            x =Convert.ToInt32 (Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is even:");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }

            Console.ReadLine();
        }
    }
}
