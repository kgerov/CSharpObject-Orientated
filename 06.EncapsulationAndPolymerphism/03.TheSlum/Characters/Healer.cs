using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;
using TheSlum.GameEngine;

namespace TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        private const int HSTARTHEALTH = 75;
        private const int HSTARTDEFENCE = 50;
        private const int HSTARTHEAL = 60;
        private const int HSTARTRANGE = 6;

        private int healPoints;

        public Healer(string id, int x, int y, Team team, int healthPoints = HSTARTHEALTH, int defensePoints = HSTARTDEFENCE, int range = HSTARTRANGE)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.HealingPoints = HSTARTHEAL;
        }

        public int HealingPoints
        {
            get
            {
                return this.healPoints;
            }
            set
            {
                this.healPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.Where(x => x.IsAlive && x.Team == this.Team && x != this).OrderBy(x => x.HealthPoints).FirstOrDefault();
        }

        public override void AddToInventory(Item item)
        {
            base.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            base.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealingPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealingPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.healPoints;
        }
    }
}
