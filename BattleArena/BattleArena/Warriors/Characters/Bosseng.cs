using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Bosseng : Warrior
    {
        public int PunchDamage { get; private set; }
        public Bosseng(int health, int attackPower, int punchDamage)
            : base("Bosseng", health, attackPower, WarriorType.Fighter)
        {
            PunchDamage = punchDamage;
            attackPower += punchDamage;
        }


        public override void Attack(Warrior target)
        {
            var totalDamage = target.AttackPower + PunchDamage;

            var dmginfo = new DamageInfo(AttackPower, "Sapak", _hasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t-> {Name}: Kaya pa ba? {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: Arayy kopo!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Boom bagsak! {target.Name}");

        }

    }
}