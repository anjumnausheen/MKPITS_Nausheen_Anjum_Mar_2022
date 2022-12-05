using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_if_with_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a number");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 3)
            {
                Console.WriteLine("x is 3");
            }
            else
            {
                Console.WriteLine("x is not 3");
            }
            Console.ReadLine();
        }
    }
}
