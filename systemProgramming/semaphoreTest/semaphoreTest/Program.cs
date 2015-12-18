using System;
using System.Threading;
public class TheClub
{
    // ёмкость семафора равна 2
    private static SemaphoreSlim s = new SemaphoreSlim(2);
    public static void Main()
    {
        for (var i = 1; i <= 5; i++)
        {
            new Thread(Enter).Start(i);
        }
    }
    private static void Enter(object id)
    {
        Console.WriteLine(id + " хочет войти");
        s.Wait();
        Console.WriteLine(id + " находится в семафоре"); // только два потока
        Thread.Sleep(1000 * (int)id); // могут одновременно
        Console.WriteLine(id + " уходит"); // выполнять этот код
        s.Release();
        Console.ReadLine();
    }
}