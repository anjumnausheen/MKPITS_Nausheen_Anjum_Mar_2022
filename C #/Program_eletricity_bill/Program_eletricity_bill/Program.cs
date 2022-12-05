using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_eletricity_bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int unit; double total=0;
            Console.WriteLine("Enter no. of units:");
            unit=Convert.ToInt32(Console.ReadLine());
           

            if(unit<=50)
            {
                total = unit * 0.5;

            }
            else if(unit>=51 && unit<=150)
            {
                total = 50 * 0.5 + (unit - 50) * 0.75;
            }
            else if(unit>=151 && unit <= 250)
            {
                total = 50 * 0.5 + 100 * 0.75 +(unit - 150) * 1.20;
            }
            else if(unit >250)
            {
                total = 50 * 0.5 + 100 * 0.75 + 100 * 1.20 + (unit -250) * 1.50;
            }
            total = total * 0.2 + total;
            Console.WriteLine("Total=" + total);
            Console.ReadLine();
        }
    }
}
