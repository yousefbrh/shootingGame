﻿using System;
using System.Data.SqlTypes;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Human : LivingThing
    {
        public int moneyBox = 0;

        public int tempAD;
        public override int GetHealth()
        {
            return health;
        }

        public Human(Guns g , int health = 0) : base(health)
        {
            tempAD = g.GetGunDamage();
        }
        
        public override int GetAttackDamage()
        {
            return attackDamage = tempAD;
        }

        public void addMoney(int money)
        {
            moneyBox += money;
        }

        public override void Damage(LivingThing attacker)
        {
            health -= attacker.GetAttackDamage();
        }
    }
}