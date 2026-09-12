using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Rene : Warrior
    {
        public int SibatDamage { get; private set; }
        public Rene(int health, int attackPower, int arrowDamage)
            : base("Rene", health, attackPower, WarriorType.Marksman)
        {
            SibatDamage = arrowDamage;
            attackPower += SibatDamage;
        }


        public override void Attack(Warrior target)
        {

            var dmginfo = new DamageInfo(AttackPower, "Sibat", _hasCriticalChance);
            TakeDamage(dmginfo);


            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {Name}: Ano bai kaya pa? {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: Run baby run!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: ahhhhh giatay! {target.Name}");

        }
    }
}