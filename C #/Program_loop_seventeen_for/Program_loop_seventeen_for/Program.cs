using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_seventeen_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1, rev = 0;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            num1 = num;

            for(;num!=0;)
            {
                rev=(rev*10)+(num%10);
                num = num / 10;
            }
            Console.WriteLine("rev=" + rev);
            if(rev==num1)
            {
                Console.WriteLine("Number is palindrome=" + num1);
            }
            else
            {
                Console.WriteLine("Number is not palindrome=" + num1);
            }
            Console.ReadLine();
        }
    }
}
