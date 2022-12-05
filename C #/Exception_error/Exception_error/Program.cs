using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_error
{
    internal class Program
    {
        /*static void checkAge(int age)
        {
            if(age<18)
            {
                throw new ArithmeticException("Access denied- You must be at least 18 years old.");
            }
            else
        {
        Console.WriteLine("Access granted-You are old enough!");
        }*/
        static void Main(string[] args)
        {
            /*int[] mynumbers = { 1, 2, 3 };
            Console.WriteLine(mynumbers[10]);*/


            /*
                        try
                        {
                            int[] mynumbers = { 1, 2, 3 };
                            Console.WriteLine(mynumbers[10]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);

                        }*/





            /* try
            {
                int[] mynumbers = { 1, 2, 3 };
                Console.WriteLine(mynumbers[10]);

            }
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong:");
            }*/





            /* try
             {
                 int[] mynumbers = { 11, 22, 13 };
                 Console.WriteLine(mynumbers[1]);
             }
             catch(Exception ex)
             {
                 Console.WriteLine("Something went wrong " + ex.Message);
             }
             finally
             {
                 Console.WriteLine("The 'try catch' is finished.");
             }*/



            try
            {
                checkAge(20);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exception occured");
            }

           /* checkAge(16);*/




        }

        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be atleast 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }

        }
    }
}
