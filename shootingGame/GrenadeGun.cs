﻿using System;

namespace ConsoleApplication1
{
    public class GrenadeGun : Guns
    {
        public GrenadeGun(int gunDamage = 0 , int gunPrice = 0): base(gunDamage , gunPrice)
        {
            
        }

        public override int GetGunDamage()
        {
            return gunDamage;
        }

        public override int GetGunPrice()
        {
            return price;
        }

    }
}