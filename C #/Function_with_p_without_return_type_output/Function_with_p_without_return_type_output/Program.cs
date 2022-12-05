using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_with_p_without_return_type_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 numbers:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your choice 1.Add 2.Subtract 3.Multiply 4.Divide");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    add(x, y);
                    break;
                case 2:
                    sub(x, y);
                    break;
                case 3:
                    mul(x, y);
                    break;
                case 4:
                    div(x, y);
                    break;

               /* default:
                    Console.WriteLine("Invalid choice");*/
            }

            Console.ReadLine();
        }
        static void add(int a,int b)
        {
            
            int c = a + b;
            Console.WriteLine("\tAddition=" + c);
        }
        static void sub (int a,int b)
        {
                
            int  c =a - b;
            Console.WriteLine("\tSubtraction=" + c);

        }
        static void mul(int a,int b)
        {
                
            int c = a * b;
            Console.WriteLine("\tMultiplication=" + c);
        }
        static void div(int a,int b)
        {
                
            int   c = (a / b);
            Console.WriteLine("\tDivision=" + c);
        }
    }
}
