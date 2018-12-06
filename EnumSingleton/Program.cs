using System;

namespace EnumSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton<Product>.Instance.DoSomething();

            Console.ReadKey();
        }
    }
}
