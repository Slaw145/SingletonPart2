using System;
using System.Collections.Generic;
using System.Text;

namespace GovernmentWithStrategy
{
    class BarakObama : Interface
    {
        private int _votes = 356;
        public int Votes { get => _votes; }

        public void ChosenPresident()
        {
            Console.WriteLine("Chosen is Barak Obama");
        }
    }
}
