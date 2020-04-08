using System;

namespace Wizard__Ninja__Samurai
{
    class Samurai : Human
    {
        public Samurai(String name) : base(name)
        {
            health = 200;
            // These are handled in Human: 
            // Name, Strength, Intelligence, Dexterity
        }

        public override int Attack(Human target)
        {
            // Calls Human.Attack first
            base.Attack(target);
            
            // Execute if under 50HP
            if (target.Health < 50) 
            {
                target.Health = 0;
                Console.WriteLine($"Critical hit! {Name} takes down {target.Name}.");
            }
            
            return target.Health;
        }

        public void Meditate()
        {
            // Heal self to full health
            Health = 200;

            Console.WriteLine($"{Name} meditates to heal themself back to full health!");
            return;
        }
    }
}
