using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter no 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no 3");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("a is greater");
            else if (b > a && b > c)
                Console.WriteLine("b is greater");
            else
                Console.WriteLine("c is greater");
            Console.ReadLine();
        }
    }
}
