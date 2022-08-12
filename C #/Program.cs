using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_not_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.WriteLine("enter a no");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(" Not Prime no");

                    break;
                }
            }
            if (i == n)
                Console.WriteLine("Prime no");
            Console.ReadLine();
        }
    }
}
