using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_program_3_loop_sum_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];

            int i, sum = 0;

            Console.WriteLine("Enter array elements:");
            for(i=0;i<=9;i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You entered elements are:");
            for(i=0;i<=9;i++)
            {
                Console.WriteLine("x[" + i + "]=" + x[i]);
                sum=sum+x[i];
            }

            Console.WriteLine("sum=" + sum); 
            Console.ReadLine();

        }
    }
}
