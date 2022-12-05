using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_three_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int ch=65;ch<=90;ch++)
            {
                Console.WriteLine(Convert.ToChar(ch));
            }
            Console.ReadLine();
        }
    }
}
