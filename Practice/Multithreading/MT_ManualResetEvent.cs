using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice.Multithreading
{
    // Dok jedan thread radi ostail thredovi cekaju da ovaj zavrsi svoj posao
    class MT_ManualResetEvent
    {
        static ManualResetEvent mre = new ManualResetEvent(false);
        static void Main()
        {
            //starting writer thread
            new Thread(Write).Start();

            for(int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();
            }
        }

        public static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing...");
            mre.Reset();
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing completed.");
            mre.Set();
        }

        public static void Read()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Waiting...");
            mre.WaitOne();
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Reading...");
        }
    }
}
