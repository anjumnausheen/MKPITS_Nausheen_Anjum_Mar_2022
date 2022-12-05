using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_four_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Following are even numbers:");

            int i = 1;
            

            do
            {
                if (i % 2 == 0)
                {
                    Console.Write("\ti = " + i);                   
                }
                i++;
            } while (i <= 100);
            Console.ReadLine();   
                
            
            
        }
    }
}
