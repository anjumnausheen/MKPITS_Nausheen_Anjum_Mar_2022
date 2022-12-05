using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_fifteen_d0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, prod = 1;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            do
            {
                prod = prod *( num % 10);
                num = num / 10;
            } while (num != 0);
            Console.WriteLine("prod="+prod);
            Console.ReadLine();
        }
    }
}
