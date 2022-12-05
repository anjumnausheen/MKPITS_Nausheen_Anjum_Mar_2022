using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_24_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, hcf = 0, i;
            Console.WriteLine("Enter two numbers:");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());

            for(i=1;i<=num1;i++)
            {
                if(num1%i==0 && num2%i==0)
                {
                    hcf = i;
                }
                
                
            }
            Console.WriteLine("HCF is = " + hcf);

            Console.ReadLine();
        }
    }
}
