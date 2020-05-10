using System;
using ConsoleApplication1;

namespace shootingGame
{
    public class Ak47Gun : Guns
    {
        public Ak47Gun(int gunDamage = 0 , int gunPrice = 0): base(gunDamage , gunPrice)
        {
            
        }

        public override int GetGunDamage()
        {
            return gunDamage;
        }

        public override int GetGunPrice()
        {
            return price;
        }

    }
}