using System;
using System.Reflection;

namespace SingletonScheme
{
    class Program
    {
        static void Main(string[] args)
        {
           Singleton singleton= Singleton.GetInstance();
        }
    }
}
