using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_22_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 1;
            while(i<=num)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Factor=" + i);
                    
                }
                i++;
            }
            Console.ReadLine();
        }
    }
}
