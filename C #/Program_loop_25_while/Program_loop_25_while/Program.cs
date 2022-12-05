using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_25_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, lcm = 0, i;
            Console.WriteLine("Enter two numbers:");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num1 * num2; i++)
            {
                if (i % num1 == 0 && i % num2 == 0)
                {
                    lcm = i;
                    break;
                }
            }
                Console.WriteLine("LCM is = " + lcm);
                Console.ReadLine();
        }
    }
}
