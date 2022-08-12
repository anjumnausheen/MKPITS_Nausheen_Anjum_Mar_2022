using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_empname_hra_da_sal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bs, hra, da, total;
            string empname;
            int empno;

            Console.WriteLine("enter emp no");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter emp name");
            empname = Console.ReadLine();
            Console.WriteLine("enter basic salary");
            bs = Convert.ToSingle(Console.ReadLine());
            if (bs > 10000)
            {
                hra = bs * 0.32f;
                da = bs * 0.45f;
            }
            else
            {
                hra = bs * 0.22f;
                da = bs * 0.35f;
            }

            total = bs + hra + da;
            Console.WriteLine("Total=" + total);
            Console.ReadLine();
        }
    }
}
