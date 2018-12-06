using System;

namespace LazySingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Display();

            Console.ReadKey();
        }
    }
}
