﻿using System;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Animals : LivingThing
    {
        private bool visible;
        private int value;
        private Human _human;

        public override int showHealth()
        {
            return health;
        }

        public override int showAttackDamage()
        {
            return attackDamage = 0;
        }

        public override void damage(LivingThing attacker)
        {
            health -= attacker.showAttackDamage();
        }

        public Animals(bool visible, int value, int health = 0) : base(health)
        {
            this.visible = visible;
            this.value = value;
        }
        
        public void visibility()
        {
            if (health <= 0 && visible == true)
            {
                visible = false;
            }
        }
        
        public void moneyTransfer()
        {
            if (health <= 0)
            {
                _human.addMoney(value);
            }
        }
    }
}