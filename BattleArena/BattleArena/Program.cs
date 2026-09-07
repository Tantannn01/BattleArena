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
            Warrior Rene = new Warrior("Rene", 100, 30, "Fireball");
            Warrior Bosseng = new Warrior("Bosseng", 200, 25, "Lightning Strike");
            Warrior Jb = new Warrior("Jb", 300, 40, "Ice Blast");


            Rene.DisplayStatus();
            Bosseng.DisplayStatus();
            Jb.DisplayStatus();


            int round = 1;
            while (Rene.IsAlive && Bosseng.IsAlive && Jb.IsAlive)
            {
                Console.WriteLine("----------Round {round} ----------");
                Rene.Attack(Bosseng);
                Bosseng.Attack(Jb);
                Jb.Attack(Rene);
                Console.WriteLine("--------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}