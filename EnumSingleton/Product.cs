using System;
using System.Collections.Generic;
using System.Text;

namespace EnumSingleton
{
    public class Product
    {
        public Product() { }

        public int State { get; set; }

        public void DoSomething()
        {
            System.Console.WriteLine("I did something for the {0} time", ++State);
        }
    }
}
