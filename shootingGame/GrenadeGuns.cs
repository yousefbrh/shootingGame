﻿using System;

namespace ConsoleApplication1
{
    public class GrenadeGuns : Guns
    {
        public GrenadeGuns(int AttackDamage = 0 , int GunCost = 0): base(AttackDamage , GunCost)
        {
            
        }

        public override int addAD()
        {
            Console.WriteLine("Grenade Damage is :");
            return ad;
        }

        public override int addCost()
        {
            Console.WriteLine("Grenade Cost is :");
            return cost;
        }

    }
}