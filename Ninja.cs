using System;

namespace Wizard__Ninja__Samurai
{
    class Ninja : Human
    {
        public Ninja(String name) : base(name)
        {
            Dexterity = 175;
            // These are handled in Human: 
            // Name, Strength, Intelligence, health
        }

        
        public override int Attack(Human target)
        {
            // Calls Human.Attack first
            base.Attack(target);
            
            // 20% chance to deal 10 extra dmg
            Random rand = new Random();
            if (rand.Next(0,5) == 0)
            {
                int dmg = 10;
                target.Health -= dmg;
                if (target.Health < 0) target.Health = 0;
                Console.WriteLine($"Critical hit! {Name} deals {dmg} extra damage.");
                return target.Health;
            }

            // Reduce target Dex
            int value = Dexterity * 5;
            target.Dexterity -= value;
            if (target.Dexterity < 0) target.Dexterity = 0;
            Console.WriteLine($"{Name} decreases {target.Name}'s Dexterity by {value}!");

            return target.Dexterity;
        }

        public int Steal(Human target)
        {
            // Deal 5 damage to target
            int dmg = 5;
            target.Health -= dmg;
            if (target.Health < 0) target.Health = 0;
            
            // Heal self for 5HP
            Health += dmg;

            Console.WriteLine($"{Name} steals {dmg} HP from {target.Name}!");
            return target.Health;
    }
    }
}
