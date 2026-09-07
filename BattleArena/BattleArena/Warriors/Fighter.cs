using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace BattleArena.Warriors
{
    public class Fighter : Warrior
    {
        public int SwordDamage { get; private set; }
        public Fighter(string name, int health, int attackPower, int swordDamage)
            : base(name, health, attackPower)
        {
            SwordDamage = swordDamage;
            attackPower += swordDamage;
        }

        public Fighter(string name, int health, int attackPower)
            : base(name, health, attackPower)
        {
            SwordDamage = SwordDamage;
        }

        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + SwordDamage;
            TakeDamage(totalDamage);
            Console.WriteLine($"\t-> {Name}: Kaya pa ba? {target.Name}!");
            Thread.Sleep(1000);

            Console.WriteLine($"\t-> {target.Name}: Aray kopo! {target.Name}");
            Console.WriteLine($"\t-------- {target.Name} --------");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Boom bagsak! {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t------ {target.Name} --------");
            Console.WriteLine($"\t  *Damage Taken: {totalDamage} *");
            Console.WriteLine($"\t  *Remaining Health: {target.Health} *");




        }
    }
}