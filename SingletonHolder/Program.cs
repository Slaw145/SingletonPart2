using System;
using System.Threading.Tasks;

namespace SingletonHolder
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.getInstance();
            singleton.DisplayMessage();

            Console.ReadKey();
        }
    }
}
