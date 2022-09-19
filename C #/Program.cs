using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_angles_triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z ,t;
            Console.WriteLine("Enter any 3 number:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z= Convert.ToInt32(Console.ReadLine());
            t = x + y + z;
            if (t == 180)
            {
                Console.WriteLine("Triangle is valid");
            }
            else
            {
                Console.WriteLine("Triangle is invalid");
            }
            Console.ReadLine();


        }
    }
}
