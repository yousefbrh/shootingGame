using System;
using System.IO;
using System.Net;
using System.Security.Policy;
using shootingGame;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ak47Gun ak47 = new Ak47Gun(70,500);
            GrenadeGun grenade = new GrenadeGun(40,300); 
            Human human = new Human(2500);
            Alians alian = new Alians(25,1500,50);
            Animals animal = new Animals(10, 300);
            Move move = new Move();
            
            Console.WriteLine("Welcome to this Shitty Game");
            Console.WriteLine("These are the Character :");
            Console.WriteLine("Human ==>   Health : " + human.GetHealth());
            Console.WriteLine("Alian ==>   Health : " + alian.GetHealth() + " Attack Damage : " + alian.GetAttackDamage() + " Value : " + alian.value);
            Console.WriteLine("Do you want to see some animals during the game? (if human kill them , animals's money will go on human pocket)");
            Console.WriteLine("Enter yes for entrance or any key for continue without animal");
            string animalAppearance = Console.ReadLine();
            if (animalAppearance == "yes")
            {
                animal.visible = true;
                
                Console.WriteLine("So, till now we have : ");
                Console.WriteLine("Human ==>   Health : " + human.GetHealth());
                Console.WriteLine("Alian ==>   Health : " + alian.GetHealth() + " Attack Damage : " + alian.GetAttackDamage() + " Value : " + alian.value);
                Console.WriteLine("Animal ==>   Health : " + animal.GetHealth()  + " Value : " + animal.value);
                
                Console.WriteLine("These are guns that available for human! Choose one of them: ");
                Console.WriteLine("1. AK47");
                Console.WriteLine("2. Grenade");
                
                int chooseGun = Convert.ToInt32(Console.ReadLine());
                
                switch (chooseGun)
                {
                 case 1:
                     Console.WriteLine("You choose AK47");
                     human.tempAD = ak47.GetGunDamage();
                     break;
                 case 2:
                     Console.WriteLine("You choose Grenade");
                     human.tempAD = grenade.GetGunDamage();
                     break;
                 default:
                     Console.WriteLine("You choose wrong number!");
                     Console.WriteLine("By default we choose AK47");
                     human.tempAD = ak47.GetGunDamage();
                     break;
                }
                
                Console.WriteLine("It's Attack Time!");
                while (human.GetHealth() > 0 && alian.GetHealth() > 0 )
                {
                    Console.WriteLine("For now this is stats : ");
                    Console.WriteLine("Human ==>   Health : " + human.GetHealth());
                    Console.WriteLine("Alian ==>   Health : " + alian.GetHealth() + " Attack Damage : " + alian.GetAttackDamage() + " Value : " + alian.value);
                    Console.WriteLine("Animal ==>   Health : " + animal.GetHealth()  + " Value : " + animal.value);

                    Console.WriteLine("Who you want to attack first? (1.Human  2.Alians)");
                    int chooseAttackFirst = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Who you want to get attack? (1.Human 2.Alians 3.Animals)");
                    int chooseGetAttacked = Convert.ToInt32(Console.ReadLine());

                    switch (chooseAttackFirst)
                    {
                        case 1 when chooseGetAttacked == 1 :
                            Console.WriteLine("Human can't attack themselves");
                            break;
                        case 1 when chooseGetAttacked == 2 :
                            alian.Damage(human);
                            if (alian.GetHealth() <= 0)
                            {
                                Console.WriteLine("Alian Died!!!!!");                        
                            }
                            break;
                        case 1 when chooseGetAttacked == 3 :
                            animal.Damage(human);
                            if (animal.GetHealth() <= 0)
                            {
                                Console.WriteLine("Animal Died!!!!!");
                                animal.visible = false;
                            }
                            break;
                        case 2 when chooseGetAttacked == 1 :
                            human.Damage(alian);
                            if (human.GetHealth() <= 0)
                            {
                                Console.WriteLine("Human Died!!!!!");                        
                            }
                            break;
                        case 2 when chooseGetAttacked == 2 :
                            Console.WriteLine("Alians can't attack themselves");
                            break;
                        case 2 when chooseGetAttacked == 3 :
                            Console.WriteLine("Alians can't attack animals");
                            break;
                        default:
                            Console.WriteLine("Your number that you added is not valid");
                            Console.WriteLine("Enter Again!");
                            break;
                    }
                }
                
                if (animal.GetHealth() <= 0)
                {
                    human.moneyBox += animal.value;
                    Console.WriteLine("Human Won!!!!");
                }
                if (alian.GetHealth() <= 0)
                {
                    human.moneyBox += alian.value;
                }
                if (human.GetHealth() <= 0)
                {
                    human.moneyBox = 0;
                    Console.WriteLine("Alian Won!!!!");
                }
            }
            else
            {
                animal.visible = false;
                Console.WriteLine("Ok! There will be no Animal");
                
                Console.WriteLine("So, till now we have : ");
                Console.WriteLine("Human ==>   Health : " + human.GetHealth());
                Console.WriteLine("Alian ==>   Health : " + alian.GetHealth() + " Attack Damage : " + alian.GetAttackDamage() + " Value : " + alian.value);
                
                Console.WriteLine("These are guns that available for human! Choose one of them: ");
                Console.WriteLine("1. AK47");
                Console.WriteLine("2. Grenade");
                
                int chooseGun = Convert.ToInt32(Console.ReadLine());
                
                switch (chooseGun)
                {
                    case 1:
                        Console.WriteLine("You choose AK47");
                        human.tempAD = ak47.GetGunDamage();
                        break;
                    case 2:
                        Console.WriteLine("You choose Grenade");
                        human.tempAD = grenade.GetGunDamage();
                        break;
                    default:
                        Console.WriteLine("You choose wrong number!");
                        Console.WriteLine("By default we choose AK47");
                        human.tempAD = ak47.GetGunDamage();
                        break;
                }
                
                Console.WriteLine("It's Attack Time!");
                
                while (human.GetHealth() > 0 && alian.GetHealth() > 0 )
                {
                    Console.WriteLine("For now this is stats : ");
                    Console.WriteLine("Human ==>   Health : " + human.GetHealth());
                    Console.WriteLine("Alian ==>   Health : " + alian.GetHealth() + " Attack Damage : " + alian.GetAttackDamage() + " Value : " + alian.value);

                    Console.WriteLine("Who you want to attack first? (1.Human  2.Alians)");
                    int chooseAttackFirst = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Who you want to get attack? (1.Human 2.Alians)");
                    int chooseGetAttacked = Convert.ToInt32(Console.ReadLine());

                    switch (chooseAttackFirst)
                    {
                        case 1 when chooseGetAttacked == 1 :
                            Console.WriteLine("Human can't attack themselves");
                            break;
                        case 1 when chooseGetAttacked == 2 :
                            alian.Damage(human);
                            if (alian.GetHealth() <= 0)
                            {
                                Console.WriteLine("Alian Died!!!!!");                        
                            }
                            break;
                        case 2 when chooseGetAttacked == 1 :
                            Console.WriteLine("There's a bullet coming to you");
                            Console.WriteLine("Do you want to dodge? :DDDDD  (enter yes to dodge or any word for stay)");
                            string dodge = Console.ReadLine();
                            if (dodge == "yes")
                            {
                                if (move.position != 1 && move.position != -1)
                                {
                                    Console.WriteLine("Want to go right or left?");
                                    string dodgeWay = Console.ReadLine();
                                    if (dodgeWay == "right")
                                    {
                                        move.right();
                                    }
                                    else if (dodgeWay == "left")
                                    {
                                        move.left();
                                    }
                                    else
                                    {
                                        Console.WriteLine("invalid input!!");
                                        Console.WriteLine("by default we move human to right!");
                                        move.right();
                                    }
                                }
                                else if (move.position == 1)
                                {
                                    Console.WriteLine("There is no space for moving right!");
                                    Console.WriteLine("we will move human to left!");
                                    move.left();
                                }
                                else if (move.position == -1)
                                {
                                    Console.WriteLine("There is no space for moving left!");
                                    Console.WriteLine("we will move human to right!");
                                    move.right();
                                }
                            }
                            else
                            {
                                human.Damage(alian);
                            }
                            if (human.GetHealth() <= 0)
                            {
                                Console.WriteLine("Human Died!!!!!");                        
                            }
                            break;
                        case 2 when chooseGetAttacked == 2 :
                            Console.WriteLine("Alians can't attack themselves");
                            break;
                        default:
                            Console.WriteLine("Your number that you added is not valid");
                            Console.WriteLine("Enter Again!");
                            break;
                    }
                }
                if (animal.GetHealth() <= 0)
                {
                    Console.WriteLine("Human Won!!!!");
                    human.moneyBox += animal.value;
                }
                if (alian.GetHealth() <= 0)
                {
                    human.moneyBox += alian.value;
                    
                }
                if (human.GetHealth() <= 0)
                {
                    Console.WriteLine("Alian Won!!!");
                    human.moneyBox = 0;
                }
                Console.WriteLine("Now Human Pocket Have = " + human.moneyBox + " Money!!");
            }
        }
        
    }
}