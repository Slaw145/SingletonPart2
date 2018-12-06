using System;
using System.Collections.Generic;
using System.Text;

namespace GovernmentWithStrategy
{
    class ChoosePresident
    {
        private Interface _strategy;

        public ChoosePresident(Interface strategy)
        {
            _strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.ChosenPresident();
        }
    }
}
