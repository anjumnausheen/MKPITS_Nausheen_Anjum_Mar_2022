using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_three_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch=65;

            while(ch<=90)
            {
                Console.WriteLine(Convert.ToChar(ch));
                ch++;
            }
            Console.ReadLine();

        }
    }
}
