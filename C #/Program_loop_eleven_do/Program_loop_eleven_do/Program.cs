using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_eleven_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fd, ld;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            ld = num % 10;
            do
            {
                fd = num % 10;
                num = num / 10;

            } while (num != 0);
            Console.WriteLine("First Digit = " + fd     +   "      Last digit = " + ld);
            Console.ReadLine();
        }
    }
}
