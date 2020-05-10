﻿using System;
using shootingGame;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ak47Gun ak47 = new Ak47Gun(70,500);
            GrenadeGun grenade = new GrenadeGun(40,300); 
            Human human = new Human(ak47,2500);
            Alians alians = new Alians(25,1500,50);
            Animals animals = new Animals(true,10, 300);
            Fight fight = new Fight(human,alians,animals);
            if (alians.GetHealth() <= 0)
            {
                human.addMoney(alians.value);
            }

            if (animals.GetHealth() <= 0)
            {
                human.addMoney(animals.value);
            }
            Console.WriteLine("human money is :" + human.moneyBox);
        }
    }
}