using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro_31_total_per_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, s3, total, per;
            string name, grd;
            Console.WriteLine("Calculate the toal,percentage and grade");
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the sub1 marks");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub2 marks");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the sub3 marks");
            s3 = Convert.ToInt32(Console.ReadLine());
            total = s1 + s2 + s3;
            per = total / 3.0;
            if (per >= 75)
                grd = "Distinction";
            else if (per < 75 && per >= 60)
                grd = "First";
            else if (per < 60 && per >= 45)
                grd = "Second";
            else
                grd = "Fail";
            Console.WriteLine("\nName of Student=" + name);
            Console.Write("Total Marks={0}\n Percentage={1} \n Grade={2}", total, per, grd);
            Console.ReadLine();
        }
    }
}
