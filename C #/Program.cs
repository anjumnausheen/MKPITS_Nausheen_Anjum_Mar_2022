using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_vowel_consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character");
            ch = Convert.ToChar(Console.ReadLine());
            if(ch >= 'A' && ch <= 'Z' || (ch >= 'a' && ch<='z'))
            {
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Console.WriteLine("alphabet is vowel");
                }
                else if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    Console.WriteLine("alphabet is vowel");
                }
                else
                {
                    Console.WriteLine("alphabet is consonant");
                }
            }
            else
            {
                Console.WriteLine("Character is not alphabet");
            }
            
            Console.ReadLine();
        }
    }
}
