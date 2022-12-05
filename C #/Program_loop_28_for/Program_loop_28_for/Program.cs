using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_28_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, num, sum = 0;

            for (j = 1; j <= 100;)
            {
                num = j;
                for (i = 2; i < num; i++)
                {

                    if (num % i == 0)
                    {
                        break;
                    }
                }
                if(i==num)
                {
                    Console.WriteLine("Prime Number is:"+i);
                    sum=sum+i;
                }
                j++;
            }
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();
        }
    }
}
