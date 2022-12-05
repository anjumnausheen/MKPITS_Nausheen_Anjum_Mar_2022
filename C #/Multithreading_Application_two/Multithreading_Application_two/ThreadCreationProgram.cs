using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading_Application_two
{
    internal class ThreadCreationProgram
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("Child Thread starts");

            //the thread is paused for 5000milliseconds

            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);

            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main:Creating the Child thread");


            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadLine();
        }

    }
}
