using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;
using TheSlum.GameEngine;

namespace TheSlum.Characters
{
    public class Warrior : Character, IAttack
    {
        private const int WSTARTHEALTH = 200;
        private const int WSTARTDEFENCE = 100;
        private const int WSTARTATTACK = 150;
        private const int WSTARTRANGE = 2;

        private int attackPoints;

        public Warrior(string id, int x, int y, Team team, int healthPoints = WSTARTHEALTH, int defensePoints = WSTARTDEFENCE, int range = WSTARTRANGE)
            : base(id, x, y, healthPoints, defensePoints, team, range)
        {
            this.AttackPoints = WSTARTATTACK;
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
            return targetsList.FirstOrDefault(x => x.IsAlive && (x.Team != this.Team));
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
