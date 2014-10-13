using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;
using TheSlum.GameEngine;

namespace TheSlum.Characters
{
    public class Mage : Character, IAttack
    {
        private const int MSTARTHEALTH = 150;
        private const int MSTARTDEFENCE = 50;
        private const int MSTARTATTACK = 300;
        private const int MSTARTRANGE = 5;

        private int attackPoints;

        public Mage(string id, int x, int y, Team team, int healthPoints = MSTARTHEALTH, int defensePoints = MSTARTDEFENCE, int range = MSTARTRANGE)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = MSTARTATTACK;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(x => x.IsAlive && (x.Team != this.Team));
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
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.attackPoints;
        }
    }
}
