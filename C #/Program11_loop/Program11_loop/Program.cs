using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program11_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Following are odd numbers:");
            int i=1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(" i = " + i);
                }
                i++;
            } while (i <= 20);
            Console.ReadLine();

        }
    }
}
