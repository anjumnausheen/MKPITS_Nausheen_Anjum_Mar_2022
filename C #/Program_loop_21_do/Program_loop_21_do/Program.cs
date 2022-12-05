using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_21_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bs, pow=1, exp, i;
            Console.WriteLine("Enter base:");
            bs=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter exponent:");
            exp=Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=exp;i++)
            {
                pow = pow * bs;
            }
            Console.WriteLine("power is = " +pow);
            Console.ReadLine();
        }
    }
}
