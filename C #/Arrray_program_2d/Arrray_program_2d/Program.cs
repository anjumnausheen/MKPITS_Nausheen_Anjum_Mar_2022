using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrray_program_2d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[3, 3];
           
            int i, j;
            
            Console.WriteLine("Enter 9 elements:");
           
            for(i=0;i<=2;i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    x[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Console.WriteLine("x["+i+"]="+x[i,j]);
                }
            }
            Console.ReadLine();
        }
    }
}
