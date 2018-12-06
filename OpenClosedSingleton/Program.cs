using System;

namespace OpenClosedSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractSingleton singleton = Singleton.getInstance();
            singleton.DisplayMessage();

            Console.ReadKey();
        }
    }
}
