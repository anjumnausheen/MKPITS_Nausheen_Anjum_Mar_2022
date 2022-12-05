using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(!(x > 3 && x < 10));//returns False because ! (not) is used to reverse the result
            Console.ReadLine();
        }
    }
}
