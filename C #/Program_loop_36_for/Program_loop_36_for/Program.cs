using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_36_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Series:");

            int sum = 0, i, n1=0,n2=1;

            Console.WriteLine(n1);
            Console.WriteLine(n2);

            for(i=0;i<7;i++)
            {
                sum = n1 + n2;
                Console.Write(sum + " ");
                n1 = n2;
                n2 = sum;

            }
            Console.ReadLine();
        }
    }
}
