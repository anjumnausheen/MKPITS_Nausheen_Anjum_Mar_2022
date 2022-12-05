using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_two_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int i , n;
            Console.WriteLine("Enter any number:");

            n=Convert.ToInt32(Console.ReadLine());
            i = n;
            while (i >= 1) 
            {
                Console.WriteLine(" i = " + i);
                i--;
            }
            Console.ReadLine();
        }
    }
}
