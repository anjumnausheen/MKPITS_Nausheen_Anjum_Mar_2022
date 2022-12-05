using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k;


            for(i=5;i>=1;i--)
            {
                for(k=1;k<=i;k++)
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
