﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;

            for(i=1;i<=5;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
        }
    }
}
