using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_divisible_notdivisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a number:");
            x = Convert.ToInt32(Console.ReadLine());
            if (x % 5 == 0)
            {
                Console.WriteLine("Number is  divisible by 5 ");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 ");
            }
            if (x % 11 == 0) 
            {
                Console.WriteLine("Number is divisible by 11");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 11");
            }

            Console.ReadLine();
        }
    }
}
