﻿using System;
using System.Data.SqlTypes;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Human : LivingThing
    {
        private bool _visible = true;
        
        public int moneyBox = 0;

        public int tempAD;
        public override int showHealth()
        {
            return health;
        }

        public Human(Guns g , int health = 0) : base(health)
        {
            tempAD = g.addAD();
        }
        
        public override int showAttackDamage()
        {
            return attackDamage = tempAD;
        }
        
        
        public void visibility()
        {
            if (health <= 0)
            {
                _visible = false;
            }
        }

        public void addMoney(int money)
        {
            moneyBox += money;
        }

        public override void damage(LivingThing attacker)
        {
            health -= attacker.showAttackDamage();
        }
    }
}