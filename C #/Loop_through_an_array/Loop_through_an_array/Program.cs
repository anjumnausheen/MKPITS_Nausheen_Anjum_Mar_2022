using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_through_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
                
            }
            Console.ReadLine();
        }
    }
}
