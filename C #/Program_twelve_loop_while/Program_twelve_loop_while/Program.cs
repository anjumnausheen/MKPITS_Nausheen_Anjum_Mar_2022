using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_twelve_loop_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, fd=0, ld;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            ld = num % 10;

            while (num != 0) 
            {
                fd = num % 10;
                num = num / 10;


            }
            Console.WriteLine("First digit=" + fd + "  Last digit=" + ld);
            sum = fd + ld;
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();
        }
    }
}
