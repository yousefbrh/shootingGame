﻿using System;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Alians : LivingThing
    {
        public int value;
        public override int GetHealth()
        {
            return health;
        }

        public override int GetAttackDamage()
        {
            return attackDamage;
        }

        public Alians(int value , int health = 0 , int attackDamage = 0) : base(health , attackDamage)
        {
            this.value = value;
        }

        public override void Damage(LivingThing attacker)
        {
            health -= attacker.GetAttackDamage();
        }

        ~Alians()
        {
            Console.WriteLine("alian died");
        }
    }
}