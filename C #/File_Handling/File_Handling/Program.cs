using System;

using System.IO;

namespace File_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "This is data from c# to myfile!";  // Create a text string
            File.WriteAllText("myfile.txt", str);  // Create a file and write the content of writeText to it

            string str1 = File.ReadAllText("myfile.txt");  // Read the contents of the file

            Console.WriteLine(str1);
        }
    }
}
