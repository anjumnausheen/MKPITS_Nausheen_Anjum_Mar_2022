using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Program to write user input to a file using streamWriter class*/

namespace File_handling2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            Console.WriteLine("Enter a string :: ");
            string str = Console.ReadLine();
            sw.WriteLine(str);

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
   
}
