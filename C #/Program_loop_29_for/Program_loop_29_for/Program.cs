using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_29_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j, num, isprime;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            for(i=2;i<=num;i++)
            {
                if(num%i==0)
                {
                    isprime = 1;
                    for(j=2;j<=i/2;j++)

                    {
                        if(i%j==0)
                        {
                            isprime = 0;
                            break;
                        }

                    }
                    if (isprime==1)
                    {
                        Console.WriteLine(" prime is =" + i);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
