﻿using System;
using System.Data.SqlTypes;

namespace ConsoleApplication1
{
    public class Human
    {
        private bool _visible = true;
        private int _moneyBox = 0;

        public int Health { get; set; }

        public Human(int health)
        {
            this.Health = health;
        }
        
        public void visibility()
        {
            if (Health <= 0)
            {
                _visible = false;
            }
        }

        public void addMoney(int money)
        {
            _moneyBox += money;
        }
    }
}