using System;
using System.Threading;

public static class Spinner
{
    public static void ShowSpinner(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
