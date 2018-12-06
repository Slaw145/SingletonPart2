using System;

namespace Government
{
    class Program
    {
        static void Main(string[] args)
        {
            Government government = Government.Instance;
            government.Election();

            Console.ReadKey();
        }
    }
}
