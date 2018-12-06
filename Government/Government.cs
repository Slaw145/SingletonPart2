using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Government
{
    public sealed class Government
    {
        private static readonly Government INSTANCE = new Government();
        private int BarakObamaVotes = 324;
        private int DonaldTrumpVotes = 425;
        private int BenjaminFranklinVotes = 231;

        private Government() { }

        public static Government Instance
        {
            get
            {
                return INSTANCE;
            }
        }

        public void Election()
        {
            int[] presidents = { BarakObamaVotes, DonaldTrumpVotes, BenjaminFranklinVotes };
            int president = presidents.Max();

            int p = Array.IndexOf(presidents, president);

            if(p==0)
            {
                Console.WriteLine("Chosen is Barak Obama");
            }
            else if (p == 1)
            {
                Console.WriteLine("Chosen is Donald Trump");
            }
            else if (p == 2)
            {
                Console.WriteLine("Chosen is Benjamin Franklin");
            }
        }
    }
}
