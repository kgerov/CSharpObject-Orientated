using System;

namespace TheSlum
{
    class Axe : Item
    {
        private const int DEFAULTHEALTH = 0;
        private const int DEFAULTDEFENCE = 0;
        private const int DEFAULTATTACK = 75;

        public Axe(string id, int healthEffect = DEFAULTHEALTH, int defenseEffect = DEFAULTDEFENCE, int attackEffect = DEFAULTATTACK)
            : base(id, healthEffect, defenseEffect, attackEffect) { }
    }
}
