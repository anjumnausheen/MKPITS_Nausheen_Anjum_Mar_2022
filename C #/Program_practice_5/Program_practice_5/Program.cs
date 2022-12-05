using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter any 3 number:");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            z=Convert.ToInt32(Console.ReadLine());

            if(x>y)
            {
                if(x>z)
                {
                    Console.WriteLine("x is greater");
                }
                else
                {
                    Console.WriteLine("z is greater:");
                }
            }
            else
            {
                if (y>z)
                {
                    Console.WriteLine("y is greater");
                }
                else 
                {
                    Console.WriteLine("z is greater:");
                }
            }
            Console.ReadLine();
            
            
               
            
           
        }
    }
}
