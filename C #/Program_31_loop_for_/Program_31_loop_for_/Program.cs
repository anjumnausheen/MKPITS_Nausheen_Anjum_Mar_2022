using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_31_loop_for_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, fd, num1, i;

            for(i=1;i<=1000;i++)
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
                if(num1==sum)
                {
                    Console.WriteLine("Number is Armstrong:"+num1);
                }
            
            
            }
            Console.ReadLine();
        }
    }
}
