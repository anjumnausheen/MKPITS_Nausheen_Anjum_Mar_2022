using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_character_to_add_variable_to_another_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstname = "John";
            string lastname = "Doe";
            string fullname=firstname+lastname;
            Console.WriteLine("FullName = "+fullname);
            Console.ReadLine();
        }
    }
}
