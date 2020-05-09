﻿using System;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Alians : LivingThing
    {
        private bool _visible = true;
        private int _value;
        private Human _human;

        public override int showHealth()
        {
            return health;
        }

        public override int showAttackDamage()
        {
            return attackDamage;
        }

        public Alians(int value , int health = 0 , int attackDamage = 0) : base(health , attackDamage)
        {
            this._value = value;
        }
        public void visibility()
        {
            if (health <= 0)
            {
                _visible = false;
            }
        }
        public void moneyTransfer()
        {
            if (health <= 0)
            {
                _human.addMoney(_value);
            }
        }

        public override void damage(LivingThing attacker)
        {
            health -= attacker.showAttackDamage();
        }
    }
}