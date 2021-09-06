using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice.Multithreading
{
    class MT_Mutex
    {
        static Mutex mutex = new Mutex();
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }

            Thread.Sleep(3000);
            mutex.ReleaseMutex();
            // mutex izbacuje exeption, ne daje paralelno
            // samo tamo gde je zakljucano moze da se otkljuca, ne moze da se otkljuca na drugom mestu
        }

        public static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Waiting...");
            mutex.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing...");
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing completed.");
            mutex.ReleaseMutex();
        }
    }
}
