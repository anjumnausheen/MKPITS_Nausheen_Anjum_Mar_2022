using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_percentage_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, t, p;
            Console.WriteLine("Enter 5 number:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e= Convert.ToInt32(Console.ReadLine());
            t = a + b + c + d + e;
            p = t / 5;

            if( p >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if( p >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if(p >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else if(p >= 60)
            {
                Console.WriteLine("Grade D");
            }
            else if(p >= 50)
            {
                Console.WriteLine("Grade E");
            }
            else if(p >= 40)
            {
                Console.WriteLine("Grade F");
            }
            else
            {
                Console.WriteLine("Fail ");
            }    
            Console.ReadLine();
        }
    }
}
