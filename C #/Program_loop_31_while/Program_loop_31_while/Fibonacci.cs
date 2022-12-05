using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_31_while
{
    internal class Fibonacci
    {
        int n1 = 0, n2 = 1;
        
        public void showdata()
        {
            Console.WriteLine("Fibonacci series");

            int sum = 0, i;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            i = 0;
            while (i < 7)
            {
                sum = n1 + n2;
                Console.Write(sum + "   ");
                n1 = n2;
                n2 = sum;
                i++;
            }
            Console.ReadLine();
        }
    }
}
