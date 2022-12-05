using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hollow_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i<=5;i++)
            {
                for(j=1;j<=5;j++)
                {
                    if(i==1 || i==5 || j==1 || j==5 )
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }
                   
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
