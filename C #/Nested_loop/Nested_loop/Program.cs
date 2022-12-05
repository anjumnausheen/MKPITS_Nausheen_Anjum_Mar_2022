using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i<=4;i++)
            {
                for(j=1;j<=3;j++)
                {
                    Console.WriteLine(" i " + i + " j " + j);
                }
            }
            Console.ReadLine();
        }
    }
}
