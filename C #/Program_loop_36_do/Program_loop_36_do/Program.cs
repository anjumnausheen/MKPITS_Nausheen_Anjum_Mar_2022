using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_36_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, i, n1 = 0, n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            i = 0;

            do
            {
                sum=n1 + n2;
                Console.Write(sum + " ");
                n1 = n2;
                n2 = sum;
                i++;

            } while (i < 7);
            Console.ReadLine();
        }
    }
}
