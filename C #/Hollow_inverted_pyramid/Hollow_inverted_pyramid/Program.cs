using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_inverted_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for(i=10;i>=1;i--)
            {
                for(k=i;k<=10;k++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=(2*i-1);j++)
                {
                    if (i == 10 || j == 1 || j == (2 * i - 1))
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
