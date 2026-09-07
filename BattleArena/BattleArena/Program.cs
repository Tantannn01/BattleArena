using battleArena.Warrios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior Rene = new Warrior();
            Rene.Name = "Rene";
            Rene.Health = 100;
            Rene.AttackPower = 30;

            Warrior Bosseng = new Warrior();
            Bosseng.Name = "Bosseng";
            Bosseng.Health = 200;
            Bosseng.AttackPower = 25;

            Warrior Jb = new Warrior();
            Jb.Name = "Jb";
            Jb.Health = 300;
            Jb.AttackPower = 40;

            Console.WriteLine($"{Rene.Name} has  " +
                $"{Rene.Health} health and {Rene.AttackPower} " + $"attack power.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{Bosseng.Name} has" +
                $" {Bosseng.Health} health and {Bosseng.AttackPower} " + $"attack power.");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{Jb.Name} has" +
               $" {Jb.Health} health and {Jb.AttackPower} " + $"attack power.");
            Console.WriteLine("--------------------------------");

            Console.ReadKey();
        }
    }
}