using System;

namespace shootingGame
{
    public class Fight
    {
        public Fight(LivingThing human, LivingThing alians, LivingThing animals)
        {
            for (;  animals.showHealth() > 0; )
            {
                animals.damage(human);
                Console.WriteLine("animal attacked!!");
            }
            for (;  alians.showHealth() > 0; )
            {
                alians.damage(human);
                Console.WriteLine("alian attacked!!");
            }
        }
        
    }
}