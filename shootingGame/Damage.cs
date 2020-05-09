﻿using System;

namespace ConsoleApplication1
{
    public class Damage
    {
        private Human _human;
        private Alians _alians;
        private Animals _animals;
        
        public void AlianGotHit(Guns g)
        {
            Console.WriteLine(_alians.Health);
            // _alians.Health -= g.addAD();
        }
        
        public void HumenGotHit()
        {
            if (_human.Health > 0)
            {
                _human.Health -= _alians.attackDamage;
            }
        }
        
        public void AnimalGotHit(Guns g)
        {
            _animals.Health -= g.addAD();
        }
    }
}