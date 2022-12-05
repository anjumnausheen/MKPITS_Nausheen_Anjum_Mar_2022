using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_if8_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter 3 number:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());

            if(x<y && x<z)
                {
                Console.WriteLine("x is smaller");
            }
            else if(y<x && y<z)
            {
                Console.WriteLine("y is smaller");
            }
            else
            {
                Console.WriteLine("z is smaller");
            }
            Console.ReadLine();
        }
    }
}
