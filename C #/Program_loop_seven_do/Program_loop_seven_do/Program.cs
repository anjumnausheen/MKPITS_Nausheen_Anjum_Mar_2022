using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_seven_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0, n;
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            do
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;

                }
                i++;
            } while (i <= n);
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();
        }
    }
}
