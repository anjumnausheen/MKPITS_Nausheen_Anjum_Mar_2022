using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirrored_right_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;

            for(i=1;i<=5;i++)
            {
                for(k=i;k<=5;k++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
