using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace nanoFramework_Threads
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");
            ArrayList threads = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                var countThread = new Thread(() => ThreadMethod(i));
                countThread.Start();
                threads.Add(countThread);
            }
            Thread.Sleep(Timeout.Infinite);

           
        }

        private static void ThreadMethod(int i)
        {
           int count = 0;



            while (true)
            {
                try
                {
                    count++;
                    //Debug.WriteLine($"From: {i}  Count: {count} Mem: {Memory.Run(false)}");
                    //Debug.WriteLine($"From: {i}  Count: {count}");
                    Console.WriteLine($"From: {i}  Count: {count}");
                }
                catch (Exception ex)
                {
                    //Debug.WriteLine($">>>Error: {ex.Message} T{i}<<<");
                    Console.WriteLine($">>>Error: {ex.Message} T{i}<<<");
                }
                Thread.Sleep(30);
            }
        }
    }
}

