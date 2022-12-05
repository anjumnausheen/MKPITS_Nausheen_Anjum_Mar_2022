using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_fifteen_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, prod = 1;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            for(;num!=0;)
            {
                prod = prod * (num % 10);
                num = num / 10;

            }
            Console.WriteLine("prod=" + prod);
            Console.ReadLine();
        }
    }
}
