using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_twenty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c0 = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0;

            int num, fd;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());
            fd = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                fd = num % 10;


                switch (fd)
                {
                    case 0:
                        c0++;
                        break;
                    case 1:
                        c1++;
                        break;
                    case 2:
                        c2++;
                        break;
                    case 3:
                        c3++;
                        break;
                    case 4:
                        c4++;
                        break;
                    case 5:
                        c5++;
                        break;
                    case 6:
                        c6++;
                        break;
                    case 7:
                        c7++;
                        break;
                    case 8:
                        c8++;
                        break;
                    case 9:
                        c9++;
                        break;

                }
                num = num / 10;
            }

                Console.WriteLine("0 occured= " + c0 + "times");
                Console.WriteLine("1 occured =" + c1 + "times");
                Console.WriteLine("2 occured =" + c2 + "times");
                Console.WriteLine("3 occured =" + c3 + "times");
                Console.WriteLine("4 occured =" + c4 + "times");
                Console.WriteLine("5 occured =" + c5 + "times");
                Console.WriteLine("6 occured =" + c6 + "times");
                Console.WriteLine("7 occured =" + c7 + "times");
                Console.WriteLine("8 occured =" + c8 + "times");
                Console.WriteLine("9 occured =" + c9 + "times");

            Console.ReadLine();


        }
    }
}
