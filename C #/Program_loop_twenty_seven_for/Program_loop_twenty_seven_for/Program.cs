using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_twenty_seven_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, j;
            /* Console.WriteLine("Enter any number:");
             num=Convert.ToInt32(Console.ReadLine());*/
            j = 1;
            while(j<= 100)
            {
                i = 2;
                num = j;
                while (i < num)
                {
                    if (num % i == 0)
                    {
                        /*Console.WriteLine("Not Prime");*/
                        break;
                    }
                    i++;
                }
                if (i == num)
                {
                    Console.WriteLine("prime Number is " + i);
                }

                j++;
            }
           

           
            Console.ReadLine();
        }
    }
}
