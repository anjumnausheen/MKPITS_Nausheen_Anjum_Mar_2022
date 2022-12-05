using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_ten_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            for(;num!=0;)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine(" Number of Digits:= " + count);
            Console.ReadLine();
        }
    }
}
