using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GovernmentWithStrategy
{
    public sealed class Government
    {
        private static readonly Government INSTANCE = new Government();

        static Interface BarakObama;
        static Interface DonaldTrump;
        static Interface BenjaminFranklin;

        private Government() { }

        public static Government Instance
        {
            get
            {
                return INSTANCE;
            }
            set
            {
                BarakObama = new BarakObama();
                DonaldTrump = new DonaldTrump();
                BenjaminFranklin = new BenjaminFranklin();
            }
        }

        public void Election()
        {
            int[] presidents = { BarakObama.Votes, DonaldTrump.Votes, BenjaminFranklin.Votes };
            int president = presidents.Max();

            if (president > 500)
            {
                ChoosePresident choosePresident = new ChoosePresident(new DonaldTrump());
                choosePresident.ContextInterface();
            }
        }
    }
}
