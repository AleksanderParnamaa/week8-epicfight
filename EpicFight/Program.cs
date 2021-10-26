using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string Villain = PickVillain();
            int heroHP = GenerateHP(hero);
            int villainHP = GenerateHP(Villain);


            Console.WriteLine($"{hero} will battle with {Villain}");
            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon();
            Console.WriteLine($"{hero} picked {heroWeapon}. {Villain} picked {villainWeapon}:");
            while(heroHP > 0 && villainHP > 0)
            {
                heroHP = heroHP - Hit(hero, Villain, heroWeapon);
                villainHP = villainHP - Hit(hero, Villain, heroWeapon);
            }
            if(heroHP >= 0)
            {
                Console.WriteLine("dark side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }
        }
        private static int Hit(string characterOne,string characterTwo, string someWeapon)
        {
            Random rnd = new Random();
            int strike = rnd.Next(0, someWeapon.Length / 2);
            Console.WriteLine($"{characterOne} hit {strike}.");
            if(strike == someWeapon.Length / 2)
            {
                Console.WriteLine($"Awesome! {characterOne} made a critical hit!") ;
            }
            else if(strike == 0)
            {
                Console.WriteLine($"{characterTwo} dodged the attack!");
            }
            return strike; 
        }
        private static int GenerateHP(string someName)
        {
            Random rnd = new Random();
            return rnd.Next(someName.Length, someName.Length +10);
        }
        private static string PickHero()
        {
            string[] superHeroes = { "Luke Skywalker", "Batman", "Spiderman", "HE MAN", "patrick", "Pickle Rick", "blob" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);
            return superHeroes[randomIndex];
            
        }
        private static string PickVillain()
        {
            string[] superVillains = { "Grandma", "Crippling depression", "Blob", "Local crackhead", "Autism", "Mart Helme", "hard drug addiction" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superVillains.Length);
            return superVillains[randomIndex];
        }
        private static string PickWeapon()
        {
            string[] Weapon = { "kööginuga", "nuke", "jeesuse armastus", };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, Weapon.Length);
            return Weapon[randomIndex];

          


        }

        }
    }

