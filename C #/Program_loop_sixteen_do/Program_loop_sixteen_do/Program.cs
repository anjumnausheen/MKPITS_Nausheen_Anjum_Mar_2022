using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_sixteen_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rev = 0;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            do
            {
                rev = (rev * 10) + (num % 10);
                num = num / 10;

            } while (num != 0);
            Console.WriteLine("rev=" + rev);
            Console.ReadLine();
        }
    }
}
