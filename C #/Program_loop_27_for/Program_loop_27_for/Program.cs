using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_27_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            for(i=2;i<num;i++)
            {
                if(num %i==0)
                {
                    Console.WriteLine("Not Prime");
                    break;
                }
                
            }
            if(i==num)
            {
                Console.WriteLine("Prime Number");
            }
            Console.ReadLine();
        }
    }
}
