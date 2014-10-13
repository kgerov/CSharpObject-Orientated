using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum
{
    class Pill : Bonus
    {
        private const int DEFATTACK = 100;
        private const int DEFTIMEOUT = 1;
        public Pill(string id, int attackEffect = DEFATTACK, int timeout = DEFTIMEOUT)
            : base(id, 0, 0, attackEffect)
        {
            base.Timeout = timeout;
            base.Countdown = timeout;
            base.HasTimedOut = false;
        }
    }
}
