﻿using System;

namespace ConsoleApplication1
{
    public class Damage
    {
        
        public void AlianGotHit(Guns g , Alians a)
        {
            a.Health -= g.addAD();
        }
        
        public void HumenGotHit(Alians a , Human h)
        {
            if (h.Health > 0)
            {
                h.Health -= a.attackDamage;
            }
        }
        
        public void AnimalGotHit(Guns g , Animals a)
        {
            a.Health -= g.addAD();
        }
    }
}