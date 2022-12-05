using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_two_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            for(i=n;i>=1;i--)
            {
                Console.WriteLine(" i = " + i);
            }
            Console.ReadLine();
        }
    }
}
