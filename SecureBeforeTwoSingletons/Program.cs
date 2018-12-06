using System;

namespace SecureBeforeTwoSingletons
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.getInstance();

            Singleton singleton2 = Singleton.getInstance();

            Console.ReadKey();
        }
    }
}
