using System;
using System.Collections.Generic;
using System.Text;

namespace SecureBeforeTwoSingletons
{
    public sealed class Singleton
    {
        private static Singleton INSTANCE;

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Singleton();
                Console.WriteLine("1. Is okay!");
            }
            else if(INSTANCE != null)
            {
                Console.WriteLine("2. Singleton can have only one instance!");
            }

            return INSTANCE;
        }
    }
}
