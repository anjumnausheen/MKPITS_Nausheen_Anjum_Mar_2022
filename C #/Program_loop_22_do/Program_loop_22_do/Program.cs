using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_22_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 1;
            do
            {
                if(num%i==0)
                {
                    Console.WriteLine("Factor=" + i);  
                    
                }
                i++;

            }while(i<=num);
            Console.ReadLine();
        }
    }
}
