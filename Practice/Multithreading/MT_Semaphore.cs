using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice.Multithreading
{
    class MT_Semaphore
    {
        static Semaphore semaphore = new Semaphore(2,2); // koliko threadova radi
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }            
        }

        public static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Waiting...");
            semaphore.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing...");
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing completed.");
            semaphore.Release();
        }
    }
}
