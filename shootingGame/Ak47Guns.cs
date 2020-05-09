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
            Console.WriteLine("Ak47 Damage is :");
            return ad;
        }

        public override int addCost()
        {
            Console.WriteLine("Ak47 Cost is :");
            return cost;
        }

    }
}