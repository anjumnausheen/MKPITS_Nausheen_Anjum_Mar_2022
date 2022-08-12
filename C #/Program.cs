using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("entrer a no");
            n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
                Console.WriteLine("no is even");
            else
                Console.WriteLine("no is odd");
            Console.ReadLine();
        }
    }
}
