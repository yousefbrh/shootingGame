﻿using System;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Animals : LivingThing
    {
        private bool visible;
        
        public int value;
        public override int GetHealth()
        {
            return health;
        }

        public override int GetAttackDamage()
        {
            return attackDamage = 0;
        }

        public override void Damage(LivingThing attacker)
        {
            health -= attacker.GetAttackDamage();
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