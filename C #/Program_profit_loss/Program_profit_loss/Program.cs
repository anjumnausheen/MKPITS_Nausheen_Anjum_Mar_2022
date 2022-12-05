using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_profit_loss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sp, cp;
            Console.WriteLine("Enter any 2 number:");
            sp = Convert.ToInt32(Console.ReadLine());
            cp = Convert.ToInt32(Console.ReadLine());

            if(sp > cp) 
            {
                Console.WriteLine("Profit");
            }
            else if(sp < cp)
            {
                Console.WriteLine("Loss");
            }
            else
            {
                Console.WriteLine("No Profit No Loss");
            }
            Console.ReadLine();
        }
    }
}
