﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Full name
            string name = "John Doe";

            //Location of the letter D
            int charPos = name.IndexOf("D");

            //Get last name
            string lastName = name.Substring(charPos);

            //Print the result
            Console.WriteLine(lastName);
            Console.ReadLine();
        }
    }
}
