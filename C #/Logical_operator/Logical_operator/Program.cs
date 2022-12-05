using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 17, y = 7, z = 7;
            Console.WriteLine(x > y && y > z);
            Console.WriteLine(x > y && y == z);
            Console.WriteLine(x > y || y > z);
            Console.WriteLine(x > y || y == z);
            Console.ReadLine();
        }
    }
}
