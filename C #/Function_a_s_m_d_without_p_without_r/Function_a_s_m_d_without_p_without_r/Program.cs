using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_a_s_m_d_without_p_without_r
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add();
            sub();
            mul();
            div();
            Console.ReadLine();

        }
        static void add()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers:");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("\tAddition=" + c);
        }
        static void sub()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers:");
            a=Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            c= a - b;
            Console.WriteLine("\tSubtraction=" + c);
        }
        static void mul()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers:");
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            c=a * b;
            Console.WriteLine("\tMultiplication=" + c);

        }
        static void div()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            c=a / b;
            Console.WriteLine("\tDivision=" + c);
        }

    }
}
