using System;
using System.Reflection;

namespace SingletonReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1=Singleton.GetInstance();
            Console.WriteLine(singleton1.GetHashCode());

            var singleton2 = Activator.CreateInstance(typeof(Singleton), true);
            Console.WriteLine(singleton2.GetHashCode());

            Console.ReadKey();
        }
    }
}
