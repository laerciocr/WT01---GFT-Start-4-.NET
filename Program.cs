using System;
using project.src.Entities;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Knight("Arus", 23, "Knight");
            Hero enemy = new Wizard("Enemy", 99, "Devil");

            Console.WriteLine(hero);

            Console.WriteLine(enemy);

            Console.WriteLine(hero.Attack());

            Console.WriteLine(enemy.Attack());
        }
    }
}
