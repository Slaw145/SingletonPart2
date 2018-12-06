using System;
using System.Collections.Generic;
using System.Text;

namespace SecureBeforeCloning
{
    public class Singleton
    {
        private static readonly Singleton INSTANCE = new Singleton();

        private Singleton() { }

        protected object MemberwiseClone()
        {
            throw new Exception("There can be only one singleton");
        }

        public static Singleton Instance
        {
            get { return INSTANCE;}
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Singleton can have only one instance!");
        }
    }
}
