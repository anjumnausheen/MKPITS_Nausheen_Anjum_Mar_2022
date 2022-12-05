using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_an_element_1d_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];

            int i;

            int search = 0;

            Console.WriteLine("Enter array elements:");

            for(i=0;i<=4;i++)
            {
                x[i]=Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered array elements:");

            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("x[" + i + "]" + x[i]);


            }
            Console.WriteLine("Enter a number to serach");
            search = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= 4; i++)
            {
                if (search == x[i])
                {
                    search = x[i];
                    Console.WriteLine("Element found in the array = " + search + " at location " + i);
                    break;
                }
            }
            Console.ReadLine();

        }
    }
}
