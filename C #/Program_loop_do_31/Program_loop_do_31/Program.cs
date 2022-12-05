using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_do_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, fd, num1, i;
             i = 1;
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
                Console.WriteLine("Number is Armstrong = " + num1);
            }
            i++;
        }while(i<=1000);
            Console.ReadLine();
        }
    }
}
