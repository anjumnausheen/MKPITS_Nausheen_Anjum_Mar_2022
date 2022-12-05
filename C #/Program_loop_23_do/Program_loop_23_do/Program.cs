using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_23_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, fact = 1;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 1;
            do
            {
                
                fact = fact * i;
                i++;

            }while(i<=num);
            Console.WriteLine("Factorial=" + fact);
            Console.ReadLine();
        }
    }
}
