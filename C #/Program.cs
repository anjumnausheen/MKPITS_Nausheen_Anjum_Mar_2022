using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_if4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 number:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x < y)
            {
                Console.WriteLine("X is smaller");
            }
            else
            {
                Console.WriteLine("y is smaller");
            }
            Console.ReadLine();

        }
    }
}

