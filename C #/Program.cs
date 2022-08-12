using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cal_dis_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string empname, desig;
            int empno;

            Console.WriteLine("enter emp no");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter emp name");
            empname = Console.ReadLine();
            Console.WriteLine("enter designation");
            desig = Console.ReadLine();

            if (desig == "manager")
                Console.WriteLine("bonus=" + 10000);
            else if (desig == "clerk")
                Console.WriteLine("bonus=" + 5000);
            else if (desig == "peon")
                Console.WriteLine("bonus=" + 2000);
            Console.ReadLine();
        }
    }
}
