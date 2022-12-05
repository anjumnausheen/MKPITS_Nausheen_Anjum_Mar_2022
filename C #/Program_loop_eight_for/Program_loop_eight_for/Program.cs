using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_eight_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            for(i=1; i<=n; i++)
            {
                if(i%2!=0)
                {
                    sum = sum + i;
                }

            }
            Console.WriteLine("sum=" + sum);
            Console.ReadLine();
        }
    }
}
