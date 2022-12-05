using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_17_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1, rev = 0;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            num1 = num;

            do
            {
                rev = (rev * 10) + (num % 10);
                num = num / 10;

            } while (num != 0);
            Console.WriteLine("rev=" + rev);
            if(rev==num1)
            {
                Console.WriteLine("Number is Palindrome"+num1);
            }
            else
            {
                Console.WriteLine("Number is not Palindrome"+num1);

            }
            Console.ReadLine();
        }
    }
}
