using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethod("Liam",5);
            MyMethod("Jenny",8);
            MyMethod("Anja",31);
            Console.ReadLine();
        }
        static void MyMethod(string fname , int age)
        {
            Console.WriteLine(fname + "   is  " +   age);
        }
    }
}
