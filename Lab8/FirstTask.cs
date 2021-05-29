using System;
using System.Diagnostics;
using System.Threading;

namespace Lab8
{
    public static class FirstTask
    {
        public static void DoTask()
        {
            Thread thread1 = new Thread(CountSum);
            Thread thread2 = new Thread(CountSum);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            CountSum();
            thread1.Start();
            thread2.Start();

            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        private static void CountSum()
        {
            int sum = 0;
            for (int i = 1; i <= 100000000; i++)
                sum += i;
        }





    }
}