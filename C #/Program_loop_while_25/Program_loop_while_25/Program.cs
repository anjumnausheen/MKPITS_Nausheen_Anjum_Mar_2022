﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_while_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, lcm = 0, i;
            Console.WriteLine("Enter two numbers:");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());

            i = 1;

            while(i<=num1*num2)
            {
                if(i%num1==0 && i%num2==0)
                {
                    lcm = i;
                    break;
                }
                i++;
            }
            Console.WriteLine("LCM is = " + lcm);
            Console.ReadLine();
        }
    }
}
