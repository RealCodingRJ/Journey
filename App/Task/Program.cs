using System;

namespace App
{
    class App
    {
        static async void Thread(byte second)
        {

            await Task.Delay(TimeSpan.FromSeconds(second));

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start...");
            Thread(10);
            Console.WriteLine("End...");
        }
    }
}