using System;
using System.Collections.Generic;
using System.Text;

namespace GovernmentWithStrategy
{
    class DonaldTrump : Interface
    {
        private int _votes = 545;
        public int Votes { get => _votes;}

        public void ChosenPresident()
        {
            Console.WriteLine("Chosen is Donald Trump");
        }
    }
}
