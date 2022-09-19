using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_alpabet_digit_special_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character:");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch>='A' && ch<='Z' || ch>='a' && ch<='z' )
            {
                Console.WriteLine("Character is alphabet");
            }
            else if(ch>='0' && ch<='9')
            {
                Console.WriteLine("Character is number");
            }
            else
            {
                Console.WriteLine("Character is special character");
            }
            Console.ReadLine();
        }
    }
}
