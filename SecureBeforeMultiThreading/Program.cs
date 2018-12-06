using System;
using System.Threading.Tasks;

namespace SecureBeforeMultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() =>
            {
                Singleton singleton1 = Singleton.getInstance();
            });

            Task.Run(() =>
            {
                Singleton singleton2 = Singleton.getInstance();
            });

            Console.ReadKey();
        }
    }
}
