using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum
{
    class Injection : Bonus
    {
        private const int DEFHEALTH = 200;
        private const int DEFTIMEOUT = 3;
        public Injection(string id, int healthEffect = DEFHEALTH, int timeout = DEFTIMEOUT)
            : base(id, healthEffect, 0, 0)
        {
            base.Timeout = timeout;
            base.Countdown = timeout;
            base.HasTimedOut = false;
        }
    }
}
