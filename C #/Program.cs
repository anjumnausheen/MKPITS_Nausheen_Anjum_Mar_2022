using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_uppercase_lowercase_alphabet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character");
            ch =Convert.ToChar(Console.ReadLine());
            if(ch>='A' && ch<='Z') 
            {
                Console.WriteLine("Character is uppercase alphabet");
            }
            else if(ch>='a' && ch<='z')
            {
                Console.WriteLine("Character is lowercase alphabet");
            }
            else
            {
                Console.WriteLine("Character is not alphabet");
            }
            Console.ReadLine();
        }
    }
}
