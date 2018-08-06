using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Warrior
    {
        //Name Health Attack Maximum Block Maximum
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttkMax {get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        //Random numbers
        Random rnd = new Random();
        public Warrior(string name = "Warrior",
            double health = 0,
            double attkMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }
        //Attack

        //generate a random attack from 1 to the max attack
        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);

        }
        //Block
        //generate a random block from 1 to the max attack
        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }


    }
}
