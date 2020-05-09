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
            Human human = new Human(ak47,2500);
            Alians alians = new Alians(25,1500,50);
            Animals animals = new Animals(true,10, 300);
            alians.damage(human);
            alians.damage(human);
            animals.damage(human);
            human.damage(alians);
            Console.WriteLine(alians.showAttackDamage());
            Console.WriteLine(alians.showHealth());
            Console.WriteLine(human.showHealth());
            Console.WriteLine(animals.showHealth());
        }
    }
}