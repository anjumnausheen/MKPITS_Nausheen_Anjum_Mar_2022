using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_a_s_m_d_without_p_with_return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            
            c = add();
            Console.WriteLine("\tAddition=" + c);
           
            c = sub();
            Console.WriteLine("\tSubtraction=" + c);
            
            c = mul();
            Console.WriteLine("\tMultiplication=" + c);
            
            c = div();
            Console.WriteLine("\tDivision=" + c);
          
            
           
            Console.ReadLine();

        }
        static int add()
        {
            int x, y, z;
            Console.WriteLine("Enter 2 numbers:");
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            z = x + y;
            return z;

        }
        static int sub()
        {
            int x, y, z;
            Console.WriteLine("Enter 2 numbers:");
            x=Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = x - y;
            return z;
        }
        static int mul()
        {
            int x, y, z;
            Console.WriteLine("Enter 2 numbers:");
            x= Convert.ToInt32(Console.ReadLine());
            y= Convert.ToInt32(Console.ReadLine());
            z= x * y;
            return z;
        }
        static int div()
        {
            int x, y, z;
            Console.WriteLine("Enter 2 numbers:");
            x = Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            z = x / y;
            return z;
        }
    }
}
