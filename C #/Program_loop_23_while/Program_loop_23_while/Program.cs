using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_23_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact = 1, i;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 1;

            while(i<=num)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("Factorial= " + fact);
            Console.ReadLine();
        }
    }
}
