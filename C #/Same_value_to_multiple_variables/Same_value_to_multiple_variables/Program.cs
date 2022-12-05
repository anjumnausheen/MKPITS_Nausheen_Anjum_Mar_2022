using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_value_to_multiple_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x,y, z;
            x = y = z = 50;
            Console.WriteLine(x+y+z);
            Console.ReadLine();
        }
    }
}
