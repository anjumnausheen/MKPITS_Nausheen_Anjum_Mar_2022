using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_mirrored_rhombus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for(i=1;i<=5;i++)
            {
                for(k=1; k<=i;k++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=5;j++)
                {
                    if(i==1|| i==5 || j==1 || j==5 )
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
