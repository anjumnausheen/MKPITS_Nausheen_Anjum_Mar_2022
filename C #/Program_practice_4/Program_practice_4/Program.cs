using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("Enter any character:");
            x = Convert.ToChar(Console.ReadLine());

            if (x >= 'a' && x <= 'z' || x >= 'A' && x <= 'Z')
            {
                Console.WriteLine("Character is alphabet:");
            }
            else if (x >= '0' && x <= '9')
            {
                Console.WriteLine("Character is Number:");
            }
            else
            {
                Console.WriteLine("Character is symbol:");
            }
            Console.ReadLine();
            
        }
    }
}
