using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_conversion_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));//Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));//Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));// Convert double to int
            Console.WriteLine(Convert.ToString(myBool));//Convert bool to string
            Console.ReadLine();
        }
    }
}
