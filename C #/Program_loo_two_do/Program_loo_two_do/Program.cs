using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loo_two_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());
            i = n;
            do
            {
                Console.WriteLine(" i = " + i);
                i--;
            } while (i >= 1);
            Console.ReadLine();

        }
    }
}
