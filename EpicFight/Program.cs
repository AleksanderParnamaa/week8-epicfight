using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = PickHero();
            string Villain = PickVillain();
            Console.WriteLine($"{hero} will battle with {Villain}");
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
            string[] superVillains = { "Grandma", "Crippling depression", "Blob", "Local crackhead", "Autism", "Mart Helme","hard drug addiction" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superVillains.Length);
            return superVillains[randomIndex];

        }
    }
}
