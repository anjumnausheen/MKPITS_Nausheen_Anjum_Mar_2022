using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for(i=5;i>=1;i--)
            {
                for(k=i;k<=5;k++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=(2*i-1);j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
