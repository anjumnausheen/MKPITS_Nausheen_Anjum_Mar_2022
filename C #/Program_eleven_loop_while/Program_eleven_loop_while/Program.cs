using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_eleven_loop_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fd=0, ld;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            ld = num % 10;
            while(num!=0)
                {
                fd = num % 10;
                num = num / 10;
            }
            Console.WriteLine("First Digit = " + fd + " Last Digit = " + ld);
            Console.ReadLine();
        }
    }
}
