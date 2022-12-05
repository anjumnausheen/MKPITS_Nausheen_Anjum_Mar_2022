using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_ten_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0;

            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            do
            {
                count++;
                num = num / 10;

            } while (num != 0);
            Console.WriteLine("Number of Digits = " + count);
            Console.ReadLine();
        }
    }
}
