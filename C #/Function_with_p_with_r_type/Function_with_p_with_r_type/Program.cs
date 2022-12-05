using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_with_p_with_r_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Enter 2 numbers:");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            
            z = add(x,y);
            Console.WriteLine("\tAddition=" + z);

            z=sub(x,y);
            Console.WriteLine("\tSubtraction=" + z);

            z= mul(x,y);
            Console.WriteLine("\tMultiplication=" + z);

            z= div(x,y);
            Console.WriteLine("\tDivision=" + z);

            Console.ReadLine();


        }
        static int add(int a,int b)
        {
            int c;
            c = a + b;
            return c;
        }
        static int sub(int a,int b)
        {
            int c;
            c = a - b;
            return c;
        }
        static int mul(int a,int b)
        {
            int c;
            c=a * b;
            return c;
        }
        static int div(int a,int b)
        {
            int c;
            c = a / b;
            return c;
        }

    }
}
