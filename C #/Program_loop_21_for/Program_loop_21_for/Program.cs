using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_21_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bs, exp, pow = 1, i;
            Console.WriteLine("Enter base");
            bs=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Exponent");
            exp=Convert.ToInt32(Console.ReadLine());

            i = 1;
            while(i<=exp)
            {
                pow = pow * bs;
                i++;
            }
            Console.WriteLine("Power is=" + pow);
            Console.ReadLine();
            
        }
    }
}
