using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progaram_loop_nine_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, prod;
            Console.WriteLine("Enter any number:");
            num = Convert.ToInt32(Console.ReadLine());

            i = 1;
            do
            {                
                prod = i * num;                
                Console.WriteLine( prod);
                i++;
            } while (i <= 10);
            Console.ReadLine();



        }
    }
}
