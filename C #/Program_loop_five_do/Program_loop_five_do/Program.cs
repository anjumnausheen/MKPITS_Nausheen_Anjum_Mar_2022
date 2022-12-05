using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_five_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            do
            {
                if(i%2!= 0)
                {
                    Console.WriteLine(" i = " + i);
                    
                }
                i++;

            }while (i <= 100);
            Console.ReadLine();
        }
    }
}
