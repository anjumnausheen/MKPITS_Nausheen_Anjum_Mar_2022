using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach(string i in cars)
            {
                Console.WriteLine(i);
            }
            //Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach(int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); 
        }
    }
}
