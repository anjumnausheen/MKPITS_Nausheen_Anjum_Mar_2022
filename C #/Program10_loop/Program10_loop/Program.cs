using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Following are odd numbers:");
            int i;
            for(i=1;i<=20;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(" i = " + i);
                }
                
            }
            Console.ReadLine();
        }
    }
}
