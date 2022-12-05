using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_program_2d_sum_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];

            int i, j, sum = 0;

            Console.WriteLine("Enter 9 elements:");

            for(i=0;i<=2;i++)
            {
                for(j=0;j<=2;j++)
                {
                    x[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(i=0;i<=2;i++)
            {
                for(j = 0;j<=2;j++)
                {
                    Console.WriteLine("x["+i+"]="+x[i,j]);

                    sum = sum + x[i, j]; 
                }

                

            }

            

            Console.WriteLine("Sum = " + sum);



            Console.ReadLine();
        }
    }
}
