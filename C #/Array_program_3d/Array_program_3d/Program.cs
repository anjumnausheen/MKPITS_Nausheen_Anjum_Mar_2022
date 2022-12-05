using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_program_3d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[ , , ] x = new int[3, 3, 3];

            int i, j, k;

            Console.WriteLine("Enter 27 elements:");

            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    for (k = 0; k <= 2; k++)
                    {
                        x[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            Console.WriteLine("Array elements are as follows:");
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    for (k = 0; k <= 2; k++)
                    {
                        Console.Write("\t" + x[i, j, k]);
                    }
                    Console.WriteLine();
                }                
            }
            Console.ReadLine();
        }
           
    }
}
