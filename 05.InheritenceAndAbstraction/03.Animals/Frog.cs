﻿using System;

namespace _03.Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender) { }

        public override void ProduceSound()
        {
            Console.WriteLine("Quaaack, quaaaack");
        }
    }
}
