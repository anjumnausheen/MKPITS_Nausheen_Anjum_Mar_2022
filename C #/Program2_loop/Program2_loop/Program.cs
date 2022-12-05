using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i=10;
            do
            {
                Console.WriteLine("i = " + i);
                i--;
            } while (i >= 1);
            Console.ReadLine();
        }
    }
}
