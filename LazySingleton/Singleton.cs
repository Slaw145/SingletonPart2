using System;
using System.Collections.Generic;
using System.Text;

namespace LazySingleton
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton Instance { get { return lazy.Value; } }

        private Singleton(){}

        public void Display()
        {
            Console.WriteLine("We got him.");
        }
    }
}
