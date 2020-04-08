using System;

namespace Wizard__Ninja__Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human humanTest = new Human("Neil");
            humanTest.printStats();

            // Wizard.Heal() test
            Wizard wizardTest = new Wizard("Wiz");
            wizardTest.Heal(humanTest);
            humanTest.printStats();
            // Wizard.Attack() test
            wizardTest.Attack(humanTest);
            humanTest.printStats();

            // Ninja.Attack() test
            Ninja ninjaTest = new Ninja("Nin");
            ninjaTest.Attack(humanTest);
            humanTest.printStats();
            // Ninja.Steal() test
            ninjaTest.Steal(humanTest);
            humanTest.printStats();
            ninjaTest.printStats();

            // Samurai.Attack() test
            Samurai samuraiTest = new Samurai("Sam");
            samuraiTest.Attack(humanTest);
            samuraiTest.Attack(humanTest);
            samuraiTest.Attack(humanTest);
            samuraiTest.Attack(humanTest);
            samuraiTest.Attack(humanTest);
            humanTest.printStats();
            samuraiTest.Attack(humanTest);
            humanTest.printStats();

            // Samurai.Meditate() test
            samuraiTest.Attack(samuraiTest);
            samuraiTest.printStats();
            samuraiTest.Meditate();
            samuraiTest.printStats();
        }
    }
}
