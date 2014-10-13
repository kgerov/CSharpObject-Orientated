using System;

namespace TheSlum
{
    class Shield : Item
    {
        private const int DEFAULTHEALTH = 0;
        private const int DEFAULTDEFENCE = 50;
        private const int DEFAULTATTACK = 0;

        public Shield(string id, int healthEffect = DEFAULTHEALTH, int defenseEffect = DEFAULTDEFENCE, int attackEffect = DEFAULTATTACK)
            : base(id, healthEffect, defenseEffect, attackEffect) { }
    }
}
