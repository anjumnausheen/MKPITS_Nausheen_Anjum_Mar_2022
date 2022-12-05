using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_over_asmd
{
    internal class Division
    {
        int g, h;

        // Simple Constructor

        public Division()
        {
            g = 0;
            h = 0;
        }
        //Parameterized Constructor

        public Division(int g, int h)
        {
            this.g = g;
            this.h = h;

        }
        public static Division operator / (Division i2,Division i3)
        {
            Division i1 = new Division();

            i1.g = i2.g  / i3.g;
            i1.h = i2.h / i3.h;
            return i1;
        }
        public void show()
        {
            Console.WriteLine(" g= " + g+" h= " + h);
        }
    }
}
