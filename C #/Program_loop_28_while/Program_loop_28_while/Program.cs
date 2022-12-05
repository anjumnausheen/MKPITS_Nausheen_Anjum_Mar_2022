using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_28_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, j,sum=0;
            j = 1;
            while(j<=100)
            {
                i = 2;
                num = j;
                while(i<num)
                {
                    if(num%i==0)
                    {
                        break;
                    }
                    i++;
                }
                if(i==num)
                {
                    Console.WriteLine("Prime number is =" + i);
                    sum=sum+i;
                }
                j++;
            }
            
            Console.WriteLine("sum= " + sum);
            Console.ReadLine();
        }
    }
}
