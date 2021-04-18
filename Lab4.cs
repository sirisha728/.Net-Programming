using System;
using System.Threading;
class Program
{
    public static void Main()
    {
        Thread ThreadObject1 = new Thread(Example1);   
        Thread ThreadObject2 = new Thread(Example2);
        ThreadObject1.Start();   
        ThreadObject2.Start();
    }
    static void Example1()
    {
        Console.WriteLine("Thread1 Started");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Thread1 Executing");
            Thread.Sleep(5000);   
        }
    }
    static void Example2()
    {
        Console.WriteLine("Thread2 Started");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Thread2 Executing");
            Thread.Sleep(5000);
        }
    }
}
