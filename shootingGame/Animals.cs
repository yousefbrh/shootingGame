﻿using System;

namespace ConsoleApplication1
{
    public class Animals
    {
        private bool visible;
        private int value;
        private Human _human;

        public int Health { get; set; }
        
        public Animals(bool visible , int health , int value)
        {
            this.visible = visible;
            Health = health;
            this.value = value;
        }
        
        public void visibility()
        {
            if (Health <= 0 && visible == true)
            {
                visible = false;
            }
        }
        
        public void moneyTransfer()
        {
            if (Health <= 0)
            {
                _human.addMoney(value);
            }
        }
    }
}