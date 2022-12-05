using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_handling_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string abc="This is data from c# to my file!";

            File.WriteAllText("Nausheen.txt", abc);

            string abc1 = File.ReadAllText("Nausheen.txt");

            Console.WriteLine(abc1);
            
        }
    }
}
