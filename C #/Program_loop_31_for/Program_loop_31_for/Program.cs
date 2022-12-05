using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_31_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num, sum = 0, fd, num1, i;*/
            /*
             for(i=1; i <= 1000; i++)
             {              
                 num = i;
                 num1 = num;
                 sum = 0;

                 for (; num != 0;)
                 {
                     fd = num % 10;
                     sum = sum + fd * fd * fd;
                     num = num / 10;
                 }
                 if (num1 == sum)
                 {
                     Console.WriteLine("Number is Armstrong:" + num1);
                 }

             }       */

            /* i = 1;
             do
             {
                 num = i;
                 num1 = num;
                 sum = 0;

                 do
                 {
                     fd = num % 10;
                     sum = sum + fd * fd * fd;
                     num = num / 10;
                 } while (num != 0);

                 if (num1 == sum)
                 {
                     Console.WriteLine("Number is Armstrong:" + num1);
                 }


                 i++;
             } while (i <= 1000);*/

            /* hcf */

            int num1, num2, hcf = 0, i;
            Console.WriteLine("Enter two numbers:: ");
            num1 = Convert.ToInt32(Console.ReadLine()); 
            num2 = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while (i <= num1)
            {
                if (num1 % i == 0 && num2 % i == 0)
                {
                    hcf = i;
                }
                i++;
            }
            Console.WriteLine("HCF is " + hcf);


            Console.ReadLine();
        }
    }
}
