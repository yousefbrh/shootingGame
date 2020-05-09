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
            return ad;
        }

        public override int addCost()
        {
            return cost;
        }

    }
}