using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i =1 ,n;
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            while(i<=n)
            {
                Console.WriteLine(" i = " + i);
                i++;
            }
            Console.ReadLine();

        }
    }
}
