﻿using System;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Alians : LivingThing
    {
        public int value;
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
            this.value = value;
        }

        public override void damage(LivingThing attacker)
        {
            health -= attacker.showAttackDamage();
        }

        ~Alians()
        {
            Console.WriteLine("alian died");
        }
    }
}