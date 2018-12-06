using System;
using System.Collections.Generic;
using System.Text;

namespace GovernmentWithStrategy
{
    class BenjaminFranklin : Interface
    {
        private int _votes = 467;
        public int Votes { get => _votes; }

        public void ChosenPresident()
        {
            Console.WriteLine("Chosen is Benjamin Franklin");
        }
    }
}
