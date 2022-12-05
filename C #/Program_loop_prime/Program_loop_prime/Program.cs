using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter a number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 2;
            while(i<num)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                i++;
            }
            if(i==num)
            {
                Console.WriteLine("Prime Number:");
            }
            Console.ReadLine();
        }
    }
}
