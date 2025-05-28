using System;
using System.Threading;

class Program
{
    static object lockA = new object();
    static object lockB = new object();

    static void Task1()
    {
        lock (lockA)
        {
            Thread.Sleep(100);
            if (Monitor.TryEnter(lockB, 1000))
            {
                try
                {
                    Console.WriteLine("Task1 acquired both locks.");
                }
                finally
                {
                    Monitor.Exit(lockB);
                }
            }
            else
            {
                Console.WriteLine("Task1 avoided deadlock.");
            }
        }
    }

    static void Task2()
    {
        lock (lockB)
        {
            Thread.Sleep(100);
            if (Monitor.TryEnter(lockA, 1000))
            {
                try
                {
                    Console.WriteLine("Task2 acquired both locks.");
                }
                finally
                {
                    Monitor.Exit(lockA);
                }
            }
            else
            {
                Console.WriteLine("Task2 avoided deadlock.");
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Task1);
        Thread t2 = new Thr
