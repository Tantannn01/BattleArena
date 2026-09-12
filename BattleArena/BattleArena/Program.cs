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
            var Rene = new Rene(100, 30, 3);
            var Jb = new Bosseng(200, 15, 5);
            var Bosseng = new Jb(150, 30, 10);

            Bosseng.DisplayStatus();
            Jb.DisplayStatus();
            Rene.DisplayStatus();

            while (Rene.IsAlive && Jb.IsAlive && Bosseng.IsAlive)
            {
                Console.WriteLine("\n\n----------------------------------------------");
                Rene.Attack(Jb);
                Jb.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Jb.Attack(Bosseng);
                Bosseng.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Bosseng.Attack(Rene);
                Rene.DisplayStatus();
            }

            Console.ReadKey();
        }
    }
}