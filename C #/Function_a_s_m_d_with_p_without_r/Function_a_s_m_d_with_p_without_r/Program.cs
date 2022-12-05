using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_a_s_m_d_with_p_without_r
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 2 numbers:");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            add(x, y);
            sub(x, y);
            mul(x, y);
            div(x, y);
            Console.ReadLine();

        }
        static void add(int a, int b)
        {
            int c= a + b;
            Console.WriteLine("\tAddition=" + c);
        }
        static void sub(int a,int b)
        {
            int c = a - b;
            Console.WriteLine("\tSubtraction=" + c);
        }
        static void mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("\tMultiplication=" + c);
        }
        static void div(int a,int b)
        {
            int c = a / b;
            Console.WriteLine("\tDivision=" + c);
        }
    }
}
