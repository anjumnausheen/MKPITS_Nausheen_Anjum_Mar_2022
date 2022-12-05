using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_29_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, num, isprime;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 2;
            do
            {
                if (num % i == 0)
                {
                    isprime = 1;
                    i++;

                    j = 2;
                    do
                    {
                        if (i % j == 0)
                        {
                            isprime = 0;
                            break;

                        }
                        j++;

                    } while (j <= i / 2);
                    Console.WriteLine("Prime is =" + i);
                }

                } while (i <= num) ;

               

            Console.ReadLine();
        }
    }
}
