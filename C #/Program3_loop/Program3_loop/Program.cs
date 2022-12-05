using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=10)
            {
                Console.WriteLine("i = " + i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
