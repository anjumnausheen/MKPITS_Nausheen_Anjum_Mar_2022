using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_20_do
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            int i;
            i = 1;

            do
            {
                Console.WriteLine(Convert.ToChar(i)+"="+i);
                i++;


            } while (i <= 255);
           
            Console.ReadLine();
        }
    }
}
