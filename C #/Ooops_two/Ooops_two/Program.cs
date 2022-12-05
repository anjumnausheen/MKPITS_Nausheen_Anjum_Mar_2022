using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops_two
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Calc c1=new Calc();
            Calc c2=new Calc();

            c1.getdata(12, 3);
            c2.getdata(8, 7);

            c1.showdata();
            c2.showdata();

            Console.ReadLine();



        }
    }

    class Calc
    {
        int x, y;

        public void getdata(int a, int b)
        {
            x = a;
            y = b;
        }
        public void showdata()
        {
            Console.WriteLine(" x= " + x + " y= " + y);
        }
    }


}
