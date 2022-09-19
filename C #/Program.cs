using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_equilateral_isosceles_scalene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter any 3 number:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
            if(x==y && y==z)
            {
                Console.WriteLine("Triangle is equilateral");

            }
            else if(x==y && y != z) 
            {
                Console.WriteLine("Triangle is isosceles");
            }
            else 
            {
                Console.WriteLine("Triangle is scalene triangle");
            }
            Console.ReadLine();
        }
    }
}
