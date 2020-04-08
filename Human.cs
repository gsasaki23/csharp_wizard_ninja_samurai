using System;

namespace Wizard__Ninja__Samurai
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
         
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
         
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
         
        // Build Attack method
        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.Health -= dmg;
            if (target.Health < 0) target.Health = 0;
            Console.WriteLine($"{Name} attacks {target.Name} for {dmg} damage.");
            return target.Health;
        }

        public void printStats()
        {
            Console.WriteLine($"{Name}'s stats: {Health} HP, {Strength} Str, {Intelligence} Int, {Dexterity} Dex\n");
            return;
        }
    }

}