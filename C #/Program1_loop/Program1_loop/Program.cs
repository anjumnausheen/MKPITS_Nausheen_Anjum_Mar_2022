﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("i = " + i);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
