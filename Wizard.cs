using System;

namespace Wizard__Ninja__Samurai
{
    class Wizard : Human
    {
        public Wizard(String name) : base(name)
        {
            Intelligence = 25;
            health = 50;

            // These are handled in Human: 
            // Name = name;
            // Strength = 3;
            // Dexterity = 3;
        }

        public override int Attack(Human target)
        {
            // Calls Human.Attack first
            base.Attack(target);

            // Reduce target Int
            int value = Intelligence * 5;
            target.Intelligence -= value;
            if (target.Intelligence < 0) target.Intelligence = 0;
            
            // Heal themself for same amount
            health += value;

            Console.WriteLine($"{Name} decreases {target.Name}'s Intelligence by {value} and healed themself for {value} HP!");
            
            return target.Intelligence;
        }

        // Heals given human for Int*10 HP
        public int Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.Health += heal;
            Console.WriteLine($"{Name} heals {target.Name} for {heal} HP!");
            return target.Health;
        }
    }
}
