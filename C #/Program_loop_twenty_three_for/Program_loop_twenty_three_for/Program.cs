using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_twenty_three_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, fact = 1;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            for(i=1; i<=num;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial=" + fact);
            Console.ReadLine();
        }
    }
}
