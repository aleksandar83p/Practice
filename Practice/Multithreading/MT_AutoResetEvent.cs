using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice.Multithreading
{
    // jedan po jedan dobijaju pristup nakon sto prvi odradi
    class MT_AutoResetEvent
    {
        static AutoResetEvent are = new AutoResetEvent(true);
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Write).Start();
            }

            Thread.Sleep(3000);
            are.Set();
            // zbog ovoga ce ici njih 2 paralelno
        }

        public static void Write()
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Waiting...");
            are.WaitOne();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing...");           
            Thread.Sleep(5000);
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing completed.");
            are.Set();
        }       
    }
}
