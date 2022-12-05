using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_20_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            
            for(i=1;i<=255;i++)
            {
                Console.WriteLine(Convert.ToChar(i) + " = " + i);
            }
            Console.ReadLine();

        }
    }
}
