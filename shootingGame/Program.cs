using System;
using shootingGame;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ak47Guns ak47 = new Ak47Guns(70,500);
            GrenadeGuns grenade = new GrenadeGuns(40,300); 
            Human human = new Human(2500);
            Alians alians = new Alians(1500,50,25);
            Animals animals = new Animals(true,300,10);
            Damage d = new Damage();
            d.AlianGotHit(ak47 , alians);
            d.HumenGotHit(alians,human);
            Console.WriteLine(alians.Health);
            Console.WriteLine(human.Health);
        }
    }
}