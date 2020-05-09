﻿using System;

namespace ConsoleApplication1
{
    public class Alians
    {
        private bool _visible = true;
        private int _value;
        private Human _human;
        
        public int Health { get; set; }
        public int attackDamage { get; set; }
        public Alians(int health , int attackDamage , int value)
        {
            this.attackDamage = attackDamage;
            Health = health;
            this._value = value;
        }

        public void visibility()
        {
            if (Health <= 0)
            {
                _visible = false;
            }
        }

        public void moneyTransfer()
        {
            if (Health <= 0)
            {
                _human.addMoney(_value);
            }
        }
    }
}