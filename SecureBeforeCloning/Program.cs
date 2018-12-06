using System;

namespace SecureBeforeCloning
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            singleton.DisplayMessage();

            Console.ReadKey();
        }
    }
}
