using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_30_arm_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, fd, num1;
            Console.WriteLine("Enter a number:");
            num=Convert.ToInt32(Console.ReadLine());

            num1 = num;

            do
            {
                fd = num % 10;
                sum = sum + fd * fd * fd;
                num = num / 10;

            } while (num != 0);

            if(num1==sum)
            {
                Console.WriteLine("Number is Armstrong");
            }
            else
            {
                Console.WriteLine("Number is not Armstrong");
            }
            Console.ReadLine();
        }
    }
}
