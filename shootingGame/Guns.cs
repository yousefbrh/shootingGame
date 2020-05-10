﻿﻿using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public abstract class Guns
    {
        protected int gunDamage;
        protected int price;

        public Guns(int gunDamage = 0 , int gunPrice = 0)
        {
            this.gunDamage = gunDamage;
            this.price = gunPrice;
        }

        public abstract int GetGunDamage();

        public abstract int GetGunPrice();
    }
}