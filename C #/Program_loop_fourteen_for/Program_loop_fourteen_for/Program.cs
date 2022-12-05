using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_fourteen_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            do
            {
                sum =sum+ num % 10;
                num = num / 10;

            } while (num != 0);
            Console.WriteLine("Sum of digits= " + sum);
            Console.ReadLine();


        }
    }
}
