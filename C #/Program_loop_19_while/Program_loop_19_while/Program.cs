using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_loop_19_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rev = 0;
            int num, fd = 0;
            Console.WriteLine("Enter any number:");
            num=Convert.ToInt32(Console.ReadLine());

            while(num!=0)
            {
                rev=(rev*10)+(num%10);
                num = num / 10;
            }
            while(rev!=0)
            {
                fd = rev % 10;
                switch(fd)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;

                        case 1:
                        Console.WriteLine("one");
                        break;

                         case 2:
                        Console.WriteLine("two");
                        break;

                        case 3:
                        Console.WriteLine("three");
                        break;

                         case 4:
                        Console.WriteLine("four");
                        break;

                        case 5:
                        Console.WriteLine("five");
                        break;

                         case 6:
                        Console.WriteLine("six");
                        break;

                        case 7:
                        Console.WriteLine("seven");
                        break;

                        case 8:
                        Console.WriteLine("eight");
                        break;

                        case 9:
                        Console.WriteLine("nine");
                        break;




                }
                rev = rev / 10;

            }
            Console.ReadLine();
        }
    }
}
