using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_twenty_seven_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, p = 1;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 2;

            while(i<=num-1)
            {
                if(num%i==0)
                {
                    p = 0;
                    break;
                }
                i=i+1;
            }
            if (p == 1)
            {
                Console.WriteLine("Number is prime");
            }
            else
            {
                Console.WriteLine("Number is not prime");
            }
            Console.ReadLine();

        }
    }
}
