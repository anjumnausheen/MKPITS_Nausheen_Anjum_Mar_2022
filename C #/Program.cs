﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_class_student
{
    class Student
    {
        public int rl, tot;
        public string nm, grd;
        public int mm, cm, pm;
        public float per;


        public void Calculate(int rl, string nm, int tot, float per, string grd)
        {
            this.rl = rl;
            this.nm = nm;
            this.tot = tot;
            this.per = per;
            this.grd = grd;
            Console.WriteLine("Roll no=" + rl);
            Console.WriteLine("student Name=" + nm);
            Console.WriteLine("Total=" + tot);
            Console.WriteLine("Percentage=" + per);
            Console.WriteLine("Grade=" + grd);



        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            Console.WriteLine("enter student roll no");
            int rol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student name");
            string name = (Console.ReadLine());
            Console.WriteLine("enter student maths mark");
            int mat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student chemistry mark");
            int chm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student physics mark");
            int phy = Convert.ToInt32(Console.ReadLine());
            int total = mat + chm + phy;
            float perc = (total / 300.0f) * 100;
            string grade;


            if (perc >= 75)
            {
                grade = "distinction";
            }
            else if (perc >= 60 && perc < 75)
            {
                grade = "first division";
            }
            else if (perc >= 45 && perc < 60)
            {
                grade = "second division";
            }
            else
            {
                grade = "Fail";
            }
            std.Calculate(rol, name, total, perc, grade);
        }


    }
}
        
    

