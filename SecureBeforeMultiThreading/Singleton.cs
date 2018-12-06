using System;
using System.Collections.Generic;
using System.Text;

namespace SecureBeforeMultiThreading
{
    class Singleton
    {
        private static Singleton INSTANCE;
        private static readonly object balanceLock = new object();

        private Singleton(){}

        public static Singleton getInstance()
        {
            if (INSTANCE == null)
            {
               lock (balanceLock)
               {
                    if (INSTANCE == null)
                    {
                        INSTANCE = new Singleton();
                        Console.WriteLine("1. Is okay!");
                    }
                    else
                    {
                        Console.WriteLine("2. Singleton can have only one instance!");
                    }
               }
            }
            return INSTANCE;
        }
    }
}
