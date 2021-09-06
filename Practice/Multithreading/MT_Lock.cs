using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice.Multithreading
{
    // Bez locka svih 5 threadova u isto vreme krecu da rade
    // sa lockom ide thread po thread, kad jedan odradi 2s krece drugi
    class MT_Lock
    {
        private static object _locker = new object();
        static void Main()
        {
            for(int i=0; i<5; i++)
            {
                new Thread(DoWork).Start();
            }
        }

        public static void DoWork()
        {
            lock (_locker)
            {
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed...");
            }
        }
    }
}
