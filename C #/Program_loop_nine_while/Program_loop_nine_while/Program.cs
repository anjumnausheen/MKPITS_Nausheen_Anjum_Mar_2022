using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_nine_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, num, prod;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());
             
            while(i<=10)
            {
                prod = i * num;
                i++;
                Console.WriteLine(prod);
            }
            
            Console.ReadLine();
        }
    }
}
