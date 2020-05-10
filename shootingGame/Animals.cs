﻿using System;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Animals : LivingThing
    {
        private bool visible;
        
        public int value;
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

        ~Animals()
        {
            visible = false;
            Console.WriteLine("animal died");
        }
    }
}