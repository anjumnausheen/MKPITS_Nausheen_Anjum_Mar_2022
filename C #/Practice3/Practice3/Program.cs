using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            i = 2;

            while(i<num)
            {
                if(num%i==0)
                {
                    Console.WriteLine("Not Prime:");
                    break;
                }
                i++;
            }
            if(i==num)
            {
                Console.WriteLine("Prime Number:");
            }
            Console.ReadLine();

        }
    }
}
