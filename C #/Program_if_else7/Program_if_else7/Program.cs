using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_if_else7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("Enter a character");
            x = Convert.ToChar(Console.ReadLine());
            if(x>='A' && x <= 'z')
            {
                Console.WriteLine("It is alphabet");
            }
            else if(x>='a' && x<='z')
                {
                Console.WriteLine("It is  alphabet");
            }
            else
            {
                Console.WriteLine("It is not alphabet");
            }
            Console.ReadLine();
        }
    }
}
