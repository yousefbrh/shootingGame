﻿using System;
 using shootingGame;

 namespace ConsoleApplication1
{
    public class Animals : LivingThing
    {
        public bool visible;
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

        public Animals(int value, int health = 0) : base(health)
        {
            this.value = value;
        }

        public void Animalappearance(bool shit)
        {
            visible = shit;
        }
        ~Animals()
        {
            
        }
    }
}