using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_post_decrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y;
            y = x--;
            Console.WriteLine("x=" + x + " y=" + y);
            Console.ReadLine();
        }
    }
}
