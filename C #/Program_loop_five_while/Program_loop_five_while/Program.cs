using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_five_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Following are odd numbers:");

            int i = 2;
            while (i <= 100)
            {
                if (i % 2 != 0) 
                {
                    Console.WriteLine(" i = " + i);
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
