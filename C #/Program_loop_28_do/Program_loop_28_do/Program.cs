using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_28_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, num, sum = 0;
            j = 1;
            do
            {
                num = j;

                i = 2;
                do
                {
                    if(num%i==0)
                    {
                        break;
                    }
                    
                    i++;
                } while(i < num);
                if (i == num)
                {
                    Console.WriteLine("Prime number is :" + i);
                    sum = sum + i;
                }
                j++;

            } while (j <= 100);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
