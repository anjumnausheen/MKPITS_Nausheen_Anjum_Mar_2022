﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_1
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            hello();//function call
            hello();//function call
            Console.ReadLine();
        }
        static void hello()
        { //function definition

            Console.WriteLine("This is hello function");
        }
    }
}
