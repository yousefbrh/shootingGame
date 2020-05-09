﻿using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public abstract class Guns
    {
        protected int ad;
        protected int cost;

        public Guns(int AttackDamage = 0 , int GunCost = 0)
        {
            ad = AttackDamage;
            cost = GunCost;
        }

        public abstract int addAD();

        public abstract int addCost();
    }
}