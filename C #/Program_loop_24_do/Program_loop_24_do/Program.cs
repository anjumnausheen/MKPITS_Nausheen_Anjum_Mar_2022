using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_24_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, hcf = 0, i;
            Console.WriteLine("Enter two numbers:");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());

            i = 1;
            do
            {
                if(num1%i==0 && num2%i==0)
                {
                    hcf = i;
                }
                i++;

            }while(i<=num1);
            Console.WriteLine("HCF is = " + hcf);
            Console.ReadLine();
        }
    }
}
