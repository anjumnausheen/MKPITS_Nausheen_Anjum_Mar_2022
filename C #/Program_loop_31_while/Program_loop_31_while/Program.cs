using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_31_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, fd, num1, i;
            i = 1;

            while (i <= 1000)
            {
                num = i;
                num1 = num;
                sum = 0;

                while (num != 0)
                {
                    fd = num % 10;
                    sum = sum + fd * fd * fd;
                    num = num / 10;
                }
                if (num1 == sum)
                {
                    Console.WriteLine("Number is Armstrong number:" + num1);
                }
                i++;
            }
            Console.ReadLine();*/

            //Fibonacci fibonacci = new Fibonacci();
           // fibonacci.showdata();
        }
    }
}
