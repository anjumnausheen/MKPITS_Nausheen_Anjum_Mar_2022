using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_22_factor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Factor=" + i); 
                }
            }
            
            Console.ReadLine();
        }
    }
}
