﻿using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    public class Guns
    {
        protected int ad;
        protected int cost;

        public Guns(int AttackDamage = 0 , int GunCost = 0)
        {
            ad = AttackDamage;
            cost = GunCost;
        }

        public virtual int addAD()
        {
            Console.WriteLine("ss");
            return 0;
        }
        public virtual int addCost()
        {
            return 0;
        }
    }
}