﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_type_casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 9;
            double myDouble = myInt; 
            
            Console.WriteLine(myInt);

            Console.WriteLine(myDouble);
            Console.ReadLine();
        }
    }
}
