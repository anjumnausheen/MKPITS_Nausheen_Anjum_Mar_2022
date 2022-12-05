using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_nine_mul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, prod;
            Console.Write("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            
            for(i=1;i<=10;i++)
            {
                prod = i * num;
                Console.WriteLine(prod);
            }
            Console.ReadLine();
        }
    }
}
