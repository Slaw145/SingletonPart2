using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedSingleton
{
    public sealed class Singleton : AbstractSingleton
    {
        private static AbstractSingleton INSTANCE;

        private Singleton() { }

        public static AbstractSingleton getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Singleton();
            }

            return INSTANCE;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Singleton can have only one instance!");
        }
    }
}
