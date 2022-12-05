using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_four_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<=100;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(" i = " + i);
                }
                
            }
            Console.ReadLine();

        }
    }
}
