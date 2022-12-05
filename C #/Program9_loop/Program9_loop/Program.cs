using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Following are even numbers:");
            int i = 1;
            while(i<=20)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(" i =" + i);
                }
                    i++;
            }
            Console.ReadLine();
        }
    }
}
