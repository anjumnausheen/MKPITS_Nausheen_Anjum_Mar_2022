using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=0, j=0, k = 0;
            for(i=1;i<=5;i++)
            {
                for(k=i;k<=5;k++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    if (j == 1 || i == j || i == 5)
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
