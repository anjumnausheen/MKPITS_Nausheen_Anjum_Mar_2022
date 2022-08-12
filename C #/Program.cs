using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_name_rate_quan_total
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float prate, total, dis;
            int quan;
            string pname;

            Console.WriteLine("enter product rate");
            prate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter product name");
            pname = Console.ReadLine();
            Console.WriteLine("enter quantity");
            quan = Convert.ToInt32(Console.ReadLine());
            total = prate * quan;
            Console.WriteLine("total=" + total);
            if (total > 2000)
                dis = total * 0.50f;
            else
                dis = total * 0.10f;
            total = prate * quan;
            Console.WriteLine("discount=" + dis);
            Console.ReadLine();
        }
    }
}
