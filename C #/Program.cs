using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 5,z;
            z = x & y;
            Console.WriteLine(z);
            z = x | y;
            Console.WriteLine(z);
            z = y >> 1;
            Console.WriteLine(z);
            z = y << 1;
            Console.WriteLine(z);
            Console.ReadLine();
        }
    }
}
