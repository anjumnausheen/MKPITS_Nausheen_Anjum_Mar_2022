using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1d_smallest_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]x= new int [5];
            int i;
            int small=1000000;

            Console.WriteLine("Enter array elements:");
            for(i=0;i<=4;i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entered elements are:");
            for(i=0;i<=4;i++)
            {
                Console.WriteLine("x["+i+"]="+x[i]);
                if (small > x[i])
                {
                    small = x[i];
                }
            }
            Console.WriteLine("Smallest element=" + small);
            Console.ReadLine();


        }
    }
}
