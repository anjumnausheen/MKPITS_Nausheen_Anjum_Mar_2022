using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_right_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i=1;i<=5;i++)
            {
                for(j = 1; j<= i ;j++)
                {
                    if(j==1||j==i||i==5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
