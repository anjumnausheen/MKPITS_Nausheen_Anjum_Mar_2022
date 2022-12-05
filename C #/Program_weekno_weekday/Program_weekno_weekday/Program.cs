using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_weekno_weekday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter any number:");
            x = Convert.ToInt32(Console.ReadLine());

            if ( x==1)
            {
                Console.WriteLine("Sunday");
            }
            else if( x==2)
            {
                Console.WriteLine("Monday");
            }
            else if (x == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if(x == 4)
            {
                Console.WriteLine("wednesday");
            }
            else if(x == 5)
            {
                Console.WriteLine("Thursday");

            }
            else if(x == 6)
            {
                Console.WriteLine("Friday");
            }
            else if(x == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.ReadLine();
        }
    }
}
