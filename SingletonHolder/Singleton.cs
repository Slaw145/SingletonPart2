using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonHolder
{
    class Singleton
    {
        private Singleton(){}

        public static Singleton getInstance()
        {
            return Holder.INSTANCE;
        }

        private static class Holder
        {
            public static Singleton INSTANCE = new Singleton();
        }

        public void DisplayMessage()
        {
            Console.WriteLine("We have singleton!!");
        }
    }
}
