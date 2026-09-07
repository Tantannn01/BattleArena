using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            var Rene = new Marksman("Rene", 100, 30);
            var Bosseng = new Fighter("Bosseng", 200, 15);
            var Jb = new Tank("Jb", 150, 30);

            Rene.DisplayStats();
            Bosseng.DisplayStats();
            Jb.DisplayStats();

            while (Rene.IsAlive && Bosseng.IsAlive && Jb.IsAlive)
            {

                Rene.Attack(Bosseng);
                Console.WriteLine("----------------------------------------------");
                Jb.Attack(Rene);
                Console.WriteLine("----------------------------------------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}