using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_If3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 number");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (x>y)
            {
                Console.WriteLine("x is greater");
            }
            else
            {
                Console.WriteLine("y is greater");
            }
            Console.ReadLine();
        }
    }
}
