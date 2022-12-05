using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int x;
            Console.WriteLine("Enter any number:");
            x=Convert.ToInt32(Console.ReadLine());

            if(x%5==0 && x%11==0)
            {
                Console.WriteLine("Number is divisible by 5 and 11");
            }
            else if(x%5==0 || x%11!=0)
            {
                Console.WriteLine("Number is divisible by 5 but not divisible by 11");
            }
            else if(x%5!=0 || x%11==0)
            {
                Console.WriteLine("Number is not divisible by 5 but divisible by 11");
            }
            else if(x%5!=0 || x%11!=0)
            {
                Console.WriteLine("Number is not divisible by 5 and 11");
            }

            Console.ReadLine();  

        }
    }
}
