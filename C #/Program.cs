using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_2d_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("enter no");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(num[i, j] + "\t");

                }
                Console.WriteLine();
                Console.ReadLine();
            }
            }
    }
}
