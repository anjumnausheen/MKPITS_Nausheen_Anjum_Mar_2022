﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_eight_do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, n;
            Console.WriteLine("Enter any number:");
            n=Convert.ToInt32(Console.ReadLine());

            i = 1;

            do
            {
                if(i%2!=0)
                {
                    sum = sum + i;
                }
                i++;
            } while (i <= n);
            Console.WriteLine(" sum = " + sum);
            Console.ReadLine();
        }
    }
}
