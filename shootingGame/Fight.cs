using System;

namespace shootingGame
{
    public class Fight
    {
        public Fight(LivingThing Human, LivingThing Alians, LivingThing Animals)
        {
            for (;  Animals.GetHealth() > 0; )
            {
                Animals.Damage(Human);
                Console.WriteLine("animal attacked!!");
            }
            for (;  Alians.GetHealth() > 0; )
            {
                Alians.Damage(Human);
                Console.WriteLine("alian attacked!!");
            }
        }
        
    }
}