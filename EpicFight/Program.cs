using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero = pickhero();
            string villan = pickvillan();
            Console.WriteLine($"{hero} will fight {villan}.");

            string heroweapon = pickweapon();
            string villanweapon = pickweapon();
            Console.WriteLine($"{hero} picked {heroweapon}. {villan} picked {villanweapon}.");
        }

        private static string pickweapon()
        {
            string[] weapon = { "plastic fork", "Banana", "frying pan", "purse" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, weapon.Length);

            return weapon[randomindex];
        }


        private static string pickhero()
        {
            string[] superHeroes = { "Superman", "Batman", "Spiderman", "Spongebob" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, superHeroes.Length);

            return superHeroes[randomindex];
        }

        private static string pickvillan()
        {
            string[] Villans = { "Joker", "Patrick", "Plankton", "Darth Vader"};
            Random rnd = new Random();
            int randomindex = rnd.Next(0, Villans.Length);

            return Villans[randomindex];
        }

    }
}
