using System;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Jb : Warrior
    {
        public int Shield { get; private set; }
        public Jb(int health, int attackPower, int shield)
            : base("jb", health, attackPower, WarriorType.Tank)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {

            var dmginfo = new DamageInfo(AttackPower, "Sipa", _hasCriticalChance);
            TakeDamage(dmginfo);



            Console.WriteLine($"\t-> {Name}: Set sa sampo toh boi! {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: ops ops ops arayy kopo!");


            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: ackkkkkkk!  {target.Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;
            var newDmginfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical);
            base.TakeDamage(damage);
        }

    }
}