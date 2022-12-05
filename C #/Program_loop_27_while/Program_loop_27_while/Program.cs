using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_27_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, j;
           
            for (j = 1; j <= 100;j++)
            {
                num = j;
                for (i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        break;
                    }
                }
                if (i == num)
                {
                    Console.WriteLine("Prime Number is = " + i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
