using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Practice.Multithreading
{
    // monitor se ponasa isto kao lock ali mi daje dodatne mogucnosti
    class MT_Monitor
    {
        private static object _locker = new object();
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(DoWork).Start();
            }
        }

        public static void DoWork()
        {
            try
            {
                Monitor.Enter(_locker);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                Thread.Sleep(2000);
                // throw new Exception();  iako ima exception, saceka 2s pa pokrece novi thread
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} completed...");                
            }
            catch(Exception e)
            {
                // error logger
                Console.WriteLine(e);
            }
            finally
            {
                Monitor.Exit(_locker);
            }          
        }
    }
}
