using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_20_while
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int i;
            i = 1;
            while(i<=255)
            {
                Console.WriteLine(Convert.ToChar(i) + "=" + i);
                i++;

            }
            Console.ReadLine();
        }
    }
}
