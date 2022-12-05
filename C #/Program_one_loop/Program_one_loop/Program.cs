using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_one_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch=65;
            do
            {
                Console.WriteLine(Convert.ToChar(ch));
                ch++;
            } while (ch <= 90);
            
            
            Console.ReadLine();
        }
    }
}
