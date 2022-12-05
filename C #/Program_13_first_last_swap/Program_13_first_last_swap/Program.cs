using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_13_first_last_swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=0, fd=0, ld=0;
            int num = 1234, num1;
            num1 = num;
            ld = num % 10;
            while(num!=0)
            {
                fd = num % 10;
                count++;
                num = num / 10;
            }
            int multi = 1, i;

            for(i=1 ;i<count;i++)
            {
                multi = multi * 10;
            }
            int temp;
            temp = num1 % multi;
            temp = ld * multi + temp;
            temp = temp - ld;
            temp = temp + fd;
            Console.WriteLine(" temp = " + temp);
            Console.ReadLine();
        }
    }
}
