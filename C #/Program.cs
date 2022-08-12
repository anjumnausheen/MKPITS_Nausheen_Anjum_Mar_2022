using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_no
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
            if (a < b && a < c)
                Console.WriteLine("a is smallest");
            else if (b < a && b < c)
                Console.WriteLine("b is smallest");
            else
                Console.WriteLine("c is smallest");
            Console.ReadLine();
        }
    }
}
