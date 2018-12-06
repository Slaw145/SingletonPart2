using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonReflection
{
    public sealed class Singleton
    {
        public static readonly Singleton INSTANCE = new Singleton();

        private Singleton()
        {
            if (INSTANCE != null)
            {
                throw new Exception("Singleton already constructed");
            }
        }

        public static Singleton GetInstance()
        {
            return INSTANCE;
        }

        public void DisplayMessage()
        {
            Console.WriteLine("We have singleton");
        }
    }
}
