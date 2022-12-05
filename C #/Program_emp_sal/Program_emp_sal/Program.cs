using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_emp_sal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bs, hra = 0, da = 0, gross;
            Console.WriteLine("Enter basic salary:");
            bs=Convert.ToInt32(Console.ReadLine());
            if(bs<=10000)
            {
                hra = 0.2 * bs;
                da = 0.8 * bs;
            }
            else if(bs<=20000)
            {
                hra = 0.25 * bs;
                da = 0.9 * bs;
            }
            else if(bs>20000)
            {
                hra = 0.3 * bs;
                da = 0.95* bs;
            }
            gross= hra+da+bs;
            Console.WriteLine("Gross=" + gross);
            Console.ReadLine();
        }
    }
}
