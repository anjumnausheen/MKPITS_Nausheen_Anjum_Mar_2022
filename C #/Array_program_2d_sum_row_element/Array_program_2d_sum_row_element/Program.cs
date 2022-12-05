using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2d array sum of column element

namespace Array_program_2d_sum_row_element
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
                sum = 0;

               


                for (j=0;j<=2;j++)
                {

                    sum = sum + x[j,i];


                }
                Console.WriteLine("Sum of column=" + sum);



            }





            Console.ReadLine();
        }
    }
}
