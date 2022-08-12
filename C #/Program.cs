using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_22_array_5_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            num[0] = 33;
            num[1] = 22;
            num[2] = 31;
            //using foreach loop to iterate over the elements of an array
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
