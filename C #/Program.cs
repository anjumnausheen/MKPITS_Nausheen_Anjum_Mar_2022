﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            if (num % 2 == 0) goto even;
            Console.WriteLine("odd");
            goto end;

        even:
            Console.WriteLine("no is even");
            goto end;
        end:
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
