using System;
using ConsoleApplication1;

namespace shootingGame
{
    public class Ak47Guns : Guns
    {
        public Ak47Guns(int AttackDamage = 0 , int GunCost = 0): base(AttackDamage , GunCost)
        {
            
        }

        public override int addAD()
        {
            return ad;
        }

        public override int addCost()
        {
            return cost;
        }

    }
}