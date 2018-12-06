using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonScheme
{
    public sealed class Singleton
    {
        private static readonly Singleton INSTANCE = new Singleton();

        private Singleton(){}

        public static Singleton GetInstance()
        {
            return INSTANCE;
        }
    }
}
