using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);

            //This will generate an error ,because myNumbers[10] does not exist.
            //The error message will be something like this :
            //'Index was outside the bounds of the array'
        }
    }
}
